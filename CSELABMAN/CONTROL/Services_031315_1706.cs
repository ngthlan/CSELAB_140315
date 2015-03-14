using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Windows;


namespace CSELABMAN.CONTROL
{
    class Services
    {
        public WebServices Network = new WebServices();
        public AppServices Local = new AppServices();
    }

    class WebServices
    {
        //string sttpostHTTPS;
        //public static string errorHTTPS;

        #region Hashing
        // hash password truoc khi gui len server
        public string hashpass(string refpass, ref bool ckchass)
        {
            string hassstring = null;
            using (MD5 md5Hash = MD5.Create())
            {
                hassstring = GetMd5Hash(md5Hash, refpass);

                //Console.WriteLine("The MD5 hash of " + refpass + " is: " + hash + ".");

                //Console.WriteLine("Verifying the hash...");
                ckchass = VerifyMd5Hash(md5Hash, refpass, hassstring);
                /*if (VerifyMd5Hash(md5Hash, refpass, hash))
                {
                    Console.WriteLine("The hashes are the same.");
                }
                else
                {
                    Console.WriteLine("The hashes are not same.");
                }*/
            }
            return hassstring;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        // Verify a hash against a string. 
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion Hashing

        #region Connect to server HTTP
        //  gui thong tin POST len web http
        public string POST(ref bool errorW, ref string errorWEBS, string Url, params string[] postdata)
        {
            string result = string.Empty;
            string data = string.Empty;
            string tem = null;
            errorW = false;
            System.Text.ASCIIEncoding ascii = new ASCIIEncoding();

            /*if (postdata.Length < 2)
            {
                MessageBox.Show("Parameters must be even , \"user\" , \"value\" , ... etc", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }*/
            //string name = null;
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data += string.Format("&{0}={1} ", postdata[i], postdata[i + 1]);
            }
            //string tem = "json="; 
            data = data.Remove(0, 1);
            //tem += System.Net.WebUtility.HtmlDecode(data);
            //data = tem;
            tem = null;
            //Console.WriteLine(data);
            byte[] bytesarr = ascii.GetBytes(data);

            foreach (byte tmp in bytesarr)
            {
                tem += tmp.ToString();
            }
            Console.WriteLine(tem);
            //MessageBox.Show(tem);
            try
            {
                //string URL = Url+"?"+postdata[0]+"="+postdata[1]+"&"+postdata[2]+"="+postdata[3];
                string URL = Url;
                WebRequest request = WebRequest.Create(URL);

                request.Method = "POST";
                //request.ContentType = "text/xml";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;
                request.Timeout = 36000;

                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                errorWEBS = ex.Message;
                errorW = true;
            }
            return result;
        }

        //  gui thong tin POST len web http security
        public string POSTHTTPS(ref bool errorW, ref string errorWEBS, string url, params string[] postdata)
        {
            string result = string.Empty;
            string data = string.Empty;
            string tem = null;
            errorW = false;
            System.Text.ASCIIEncoding ascii = new ASCIIEncoding();

            /*if (postdata.Length < 2)
            {
                MessageBox.Show("Parameters must be even , \"user\" , \"value\" , ... etc", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }*/
            //string name = null;
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data += string.Format("&{0}={1} ", postdata[i], postdata[i + 1]);
            }
            //string tem = "json="; 
            data = data.Remove(0, 1);
            //tem += System.Net.WebUtility.HtmlDecode(data);
            //data = tem;
            tem = null;
            //Console.WriteLine(data);
            byte[] bytesarr = ascii.GetBytes(data);

            foreach (byte tmp in bytesarr)
            {
                tem += tmp.ToString();
            }
            Console.WriteLine(tem);
            //MessageBox.Show(tem);
            try
            {
                Uri uri = new Uri(url);

                WebRequest http = HttpWebRequest.Create(url);
                http.Timeout = 36000;
                HttpWebResponse response = (HttpWebResponse)http.GetResponse();
                Stream stream = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(stream);
                result = streamread.ReadToEnd();
                streamread.Close();
                //Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                errorWEBS = ex.Message;
                errorW = true;
            }
            return result;
        }

        #endregion Connect to server HTTP

        #region Connect to server TCP
        public void DemocpListener(string ipaddress, Int32 port, ref string response, ref bool errEX, ref string ExMess)
        {
            TcpListener server = null;
            errEX = false;
            try
            {
                // Set the TcpListener on port 13000.
                //Int32 port = 13000;
                //IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                IPAddress localAddr = IPAddress.Parse(ipaddress);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop. 
                while (true)
                {
                    response = "Waiting for a connection... ";
                    Console.Write(response);

                    // Perform a blocking call to accept requests. 
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    response = "Connected!";
                    Console.WriteLine(response);

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client. 
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        response = "Received: {0}" + data;
                        Console.WriteLine(response);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        response = "Sent: {0}" + data;
                        Console.WriteLine(response);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                errEX = true;
                ExMess = "SocketException: {0}" + e.Message;
                Console.WriteLine(response);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            response = "Waiting....";
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
        #endregion Connect to server TCP

        #region Response from server HTTP
        //public bool ErrRes = false;
        //public string MessRes = null;
        //public string MessResstt = null;
        public void showresponse(string path, string Data, string url, ref bool ErrRes, ref string MessRes, ref string MessResstt)
        {
            bool cmpres = false;
            try
            {
                Console.WriteLine("Data[0] is : \"" + Data[0] + "\", Data[1] is : \"" + Data[1] + "\"");
                if (Data[0].Equals('<') || Data[0].Equals('?') || Data[0].Equals('!') || Data[0].Equals(' ') || Data[0].Equals('\r') || Data[0].Equals('\n')
                 || Data[1].Equals('<') || Data[1].Equals('?') || Data[1].Equals('!') || Data[1].Equals(' ') || Data[1].Equals('\r') || Data[1].Equals('\n'))
                    cmpres = true;
                else
                    cmpres = false;
            }
            catch (Exception ex)
            {
                ErrRes = true;
                MessRes = ex.Message;
                //MessageBox.Show(ex.Message);
            }

            /*if (ErrRes)
            {
                ErrRes = false;
                MessRes="Connection timed out";
            }
            else */
            if (cmpres)
            {
                System.Diagnostics.Process myproc = new System.Diagnostics.Process();
                
                //string mydocpath = @"C:\Users\Public\Documents\";
                CONTROL.Services services = new CONTROL.Services();
                services.Local.writetofile(Data, path);
                //richText_Stt.Text = "Connected successful \n" + url;
                MessResstt = "Connected successfully";
                System.Diagnostics.Process.Start(path);
                cmpres = false;
            }
            else
            {
                MessResstt = "Connected to : " + url + "\n" + Data;
                //Console.WriteLine("Method successful.");
            }
            /*
              IAsyncResult result;
        Action action = () =>
        {
            // Your code here
        };

        result = action.BeginInvoke(null, null);

        if (result.AsyncWaitHandle.WaitOne(10000))
            Console.WriteLine("Method successful.");
        else
            Console.WriteLine("Method timed out.");
        }*/

        #endregion Response from server HTTP
        }
    }
    class AppServices
    {
        #region Write and Read file

        // doc data tu file txt
        public string resultread;
        public string readfiletxt(ref bool errread, ref string errres, string path)
        {
            if (!File.Exists(path))
            {
                errread = true;
                errres = " File is not exist!";
                return null;
            }
            else
            {
                try
                {
                    string[] lines = File.ReadAllLines(path);
                    resultread = stringarraytostring(lines);
                }
                catch (Exception e)
                {
                    errread = true;
                    errres = e.Message;
                }
            }
            return resultread;
        }

        public void writetxt(ref bool errwrite, ref string errres, string[] data, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {
                for (int i = 0; i < data.Length ; i++)
                {
                    sw.WriteLine(data[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                errwrite = true;
                errres = e.Message;
            }

        }

        // ghi data vao file txt
        public void writetofiletxt(ref bool errwrite, ref string errres, string data, string path)
        {
            char[] tmparray = new char[data.Length];                // tao new char []
            string[] tmpstrarray = stringtostringarray(data);       // doi string thanh string[]
            errres = null;
            errres = stringarraytostring(tmpstrarray);              // doi string[] thanh string
            //Console.WriteLine("errres is : \n" + errres);
            //Console.WriteLine("tmpstrarray is : "+tmpstrarray);
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Close();
            }

            writetxt(ref errwrite,ref errres, tmpstrarray, path);
            /*TextWriter tw = new StreamWriter(path);
            tw.WriteLine(data);
            tw.Close();    */
        }

        // ghi data vao file bat ki
        public void writetofile(string data, string path)
        {
            StreamWriter sw;
            //sw = File.CreateText("c:\\testtext.txt");
            //sw.WriteLine("this is just a test");

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Close();
            }
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine(data);
            tw.Close();
        }
        #endregion Write and Read file

        #region Convert Type
        // doi char[] sang string
        string resultstring;
        public string chararraytostring(char[] inchart)
        {
            resultstring = string.Empty;
            foreach (char tmp in inchart)
            {
                resultstring += tmp.ToString();
            }
            return resultstring;
        }

        // doi char[] sang string
        public char[] chararray = null;
        public char[] stringtochararray(string data)
        {
            chararray = new char[data.Length];
            data.CopyTo(0, chararray, 0, data.Length);
            return chararray;
        }

        // doi char[] sang char
        char resultchar;
        public char chararraytochar(char[] inchart)
        {
            foreach (char tmp in inchart)
            {
                resultchar += tmp;
            }
            return resultchar;
        }

        // doi Byte[] sang HexString
        public string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        // doi char[] sang string bo dau cach
        public string CharArrayToString(char[] data)
        {
            string des = null;
            foreach (char tmp in data)
            {
                if (!tmp.Equals(' '))
                    des += tmp.ToString();
            }
            return des;
        }

        // chuyen string sang string[]
        public string[] resultstringarray = null;
        public string[] stringtostringarray(string data)
        {
            char[] tmparray = new char[data.Length];            // tao new char[] tam thoi co kich thuoc = data
            data.CopyTo(0, tmparray, 0, data.Length);           // doi string thanh char[]
            string tmpstr = null;                               // tao string tam thoi
            string[] tmpstrarray = new string[data.Length];     // tao string[] tam thoi co kich thuoc = <kich thuoc data>
            int countstrarray = 0;                              // so dem cua string[] dang xet
            int countchararray = 0;                             // so dem cua char[] dang xet
            foreach (char tmpchar in tmparray)                  // xet moi char tam thoi cua char[]
            {
                if (countchararray == data.Length - 1)     // neu so dem char[] = <kich thuoc data> -1 thi ngat 
                {                                               // va ... 
                    tmpstr += tmpchar.ToString();               // lay char cuoi cung gan vao string tam thoi
                    tmpstrarray[countstrarray] = tmpstr;        // gan string[] tam thoi = string tam thoi
                    //Console.WriteLine("tmpstrarray[" + countstrarray + "] is : " + tmpstrarray[countstrarray]);
                    countstrarray += 1;                         // cong so dem string[] len 1
                    tmpstr = null;                              // xoa bo nho string tam thoi
                    break;
                }
                else if (tmpchar.Equals('\n'))                       // neu char tam thoi la \n thi gan string[] tam thoi = string tam thoi
                {                                               // va gan string tam thoi = null
                    tmpstrarray[countstrarray] = tmpstr;
                    tmpstr = null;
                    //Console.WriteLine("tmpstrarray["+countstrarray+"] is : "+ tmpstrarray[countstrarray]);
                    countstrarray += 1;                         // cong so dem string[] len 1
                    countchararray += 1;                        // cong so dem char[] len 1
                }
                else
                {
                    tmpstr += tmpchar.ToString();               // doi tung char[] thanh string
                    countchararray += 1;                        // cong so dem char[] len 1
                }
            }

            resultstringarray = new string[countstrarray];            // tao string[] co kich thuoc = <kich thuoc string[] tam thoi>
            for (int i = 0; i <= countstrarray - 1; i++)        // gan cac tring[] tam thoi vao string[] ket qua
            {
                resultstringarray[i] = tmpstrarray[i];
            }
            tmpstrarray = null;                                 // xoa bo nho string[] tam thoi
            return resultstringarray;
        }

        // chuyen string[] sang string
        public string resultstringfromarray;
        public string stringarraytostring(string[] data)
        {
            resultstringfromarray = null;               // xoa du lieu cua resultstringfromarray

            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                    resultstringfromarray += data[i];
                else
                    resultstringfromarray += data[i] + "\n";
            }

            return resultstringfromarray;
        }

        #endregion Convert Type

        #region Configuration COMport

        // define the function refresh COM port list
        public void RefreshserialPortRFIDList(ref ComboBox cmB_COMport, ref bool errorCOM, ref SerialPort serialPortRFID)
        {
            // Determain if the list of com port names has changed since last checked
            string selected = RefreshserialPortRFIDList(ref errorCOM,cmB_COMport.Items.Cast<string>(), cmB_COMport.SelectedItem as string, serialPortRFID.IsOpen);

            // If there was an update, then update the control showing the user the list of port names
            if (!String.IsNullOrEmpty(selected))
            {
                cmB_COMport.Items.Clear();
                cmB_COMport.Items.AddRange(OrderedPortNames());
                cmB_COMport.SelectedItem = selected;
            }
        }
        private string[] OrderedPortNames()
        {
            // Just a placeholder for a successful parsing of a string to an integer
            int num;

            // Order the serial port names in numberic order (if possible)
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }

        private string[] ports;
        private string RefreshserialPortRFIDList(ref bool errorCOM, IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {
            // Create a new return report to populate
            string selected = null;

            // Retrieve the list of ports currently mounted by the operating system (sorted by name)
            ports = SerialPort.GetPortNames();

            if (ports.Length != 0)
            {
                errorCOM = false;
                // First determain if there was a change (any additions or removals)
                bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;

                // If there was a change, then select an appropriate default port
                if (updated)
                {
                    // Use the correctly ordered set of port names
                    ports = OrderedPortNames();

                    // Find newest port if one or more were added
                    string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                    // If the port was already open... (see logic notes and reasoning in Notes.txt)
                    if (PortOpen)
                    {
                        if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                        else if (!String.IsNullOrEmpty(newest)) selected = newest;
                        else selected = ports.LastOrDefault();
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(newest)) selected = newest;
                        else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                        else selected = ports.LastOrDefault();
                    }
                }
            }

            // If there was a change to the port list, return the recommended default selection
            return selected;
        }

        // gan tring vao ComboBox hien tai
        public void setCOMBO(ref ComboBox cmb, char[] data)
        {
            string tmp = chararraytostring(data);
            cmb.Text = tmp;
        }
        #endregion Configuration COMport
        
        #region Process

        public void demoprocess()
        {
            string tmp = null;
            /*foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                tmp += p.ProcessName + " - " + p.Id+"\n";*/
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcessesByName("firefox"))
                tmp += p.ProcessName + " - " + p.Id + "\n";
                MessageBox.Show(tmp);
        }
     
        #endregion Process

        #region demoCOMport

        static bool _continue;
        static SerialPort _serialPort;
        public void demoCOM()
        {
            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            /*_serialPort.PortName = SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);*/

            _serialPort.PortName = SetPortName("COM7");
            _serialPort.BaudRate = SetPortBaudRate(9600);
            _serialPort.Parity = SetPortParity(Parity.None);
            _serialPort.DataBits = SetPortDataBits(8);
            _serialPort.StopBits = SetPortStopBits(StopBits.One);
            _serialPort.Handshake = SetPortHandshake(Handshake.None);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Type QUIT to exit");

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    _serialPort.WriteLine(
                        String.Format("<{0}>: {1}", name, message));
                }
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Time out");
                }
            }
        }

        // Display Port values and prompt user to enter a port. 
        public string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
        // Display BaudRate values and prompt user to enter a value. 
        public int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        // Display PortParity values and prompt user to enter a value. 
        public Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value. 
        public int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value. 
        public StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter StopBits value (None is not supported and \n" +
             "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("End Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
        #endregion demoCOMport

    }
}
