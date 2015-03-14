using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace CSELABMAN.CONTROL
{
    public partial class TRY : Form
    {
        public TRY()
        {
            InitializeComponent();
            InitializeControlValues();
        }

        string mypath = null;                                   // ten path de luu file html response
        Services services = new Services();                     // dich vu ho tro
        public bool errReadFile = false;                        // kiem tra loi doc file
        public bool errWriteFile = false;                       // kiem ta loi ghi file
        public string responseReadFile = null;                  // phan hoi sau khi doc file
        public string responseWriteFile = null;                 // phan hoi sau khi ghi file
        public bool ckcadd = false;
        public bool ckchash = false;
        public bool errorCOM = false;      //kiem tra cong COM ngat bat thuong hay khong
        public bool errorCONN = false;     //kiem tra cong COM co bi chiem giu hay khong
        private CSELABMAN.Properties.Settings settings = CSELABMAN.Properties.Settings.Default;

        public static string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create);
        string mypathappWEB = mydocpath + @"\Response.html";

        #region Local Methods
        private void InitializeControlValues()
        {
            CONTROL.Services services = new CONTROL.Services();
            cmB_Parity.Items.Clear(); cmB_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            //cmB_Parity.Text = settings.Parity.ToString();
            cmbStopBits.Text = settings.StopBits.ToString();
            cmbDataBits.Text = settings.DataBits.ToString();
            //cmB_Parity.Text = settings.Parity.ToString();
            //cmB_Baud.Text = settings.BaudRate.ToString();

            // refresh the COM port in the form if it's available 
            try
            {
                services.Local.RefreshserialPortRFIDList(ref this.cmB_COMport, ref errorCOM, ref this.serialPortRFID);
            }
            catch (UnauthorizedAccessException)
            {
                errorCONN = true;
            }
            // If it is still avalible, select the last com port used
            if (cmB_COMport.Items.Contains(settings.PortName))
            {
                cmB_COMport.Text = settings.PortName;
                errorCOM = false;
            }
            else if (cmB_COMport.Items.Count > 0) cmB_COMport.SelectedIndex = cmB_COMport.Items.Count - 1;
            else if (!errorCOM)
            {
                //MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCOM = true;
                cmB_Baud.Items.Clear();
                cmB_Parity.Items.Clear();
                cmB_COMport.Items.AddRange(new Object[] { });
                cmB_Baud.Items.AddRange(new Object[] { });
                cmB_Parity.Items.AddRange(new Object[] { });
                //rictext_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                 textBox_sttCOM.Text = "No COMport!";
                //this.Close();

            }
        }
        #endregion Local Methods

        #region Events

        public const int maxlength = 7;
        private string txt_S;
        public string txt_D = "";
        //private string temp = "";
        public char[] temp = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //private int num_temp;
        public string errorWEB;
        public bool errorW = false;
        public string res2, sttdes;


        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            CONTROL.Services services = new CONTROL.Services();
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.lb_stt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                byte[] buffer = new byte[serialPortRFID.BytesToRead];
                serialPortRFID.Read(buffer, 0, buffer.Length);
                txt_S = services.Local.ByteArrayToHexString(buffer);
                txt_S.CopyTo(3, temp, 0, 10 + 4);
                //Console.WriteLine("temp is : "+temp);
                txt_D = services.Local.CharArrayToString(temp);
                Console.WriteLine("RFID is : " + txt_D);
                lb_stt.Text = txt_D;
                if (txt_S.Length > maxlength)
                {
                    txt_S = "";
                    txt_D = "";
                    buffer = new byte[14];
                }

                //string mydocpath = @"C:/xampp/htdocs/DTB/";
                string mydocpath = @"C:\USERs\Public\Documents\";
                string mypath = mydocpath + @"LAB_MANAGER_file.txt";
                services.Local.writetofile(lb_stt.Text, mypath);
            }
        }


        private void serialPortRFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPortRFID.BytesToRead >= maxlength)
                SetText("");
        }


        #endregion Events

        #region Button Clicks
        string mypathF = string.Empty;                  // ten path de luu file txt
        private void button_Write_Click(object sender, EventArgs e)
        {
            richTextBox_Status.Text = null;
            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this, "The filename is empty!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_path.Text))
                    mypathF = textBox_filename.Text;
                else
                    mypathF = textBox_path.Text + "/" + textBox_filename.Text;
                services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, richTextBox_Send.Text, mypathF);
                //richTextBox_Status.Text = responseWriteFile;

                if (errWriteFile)
                {
                    errWriteFile = false;
                    richTextBox_Status.Text = "Error while Writing data to file \n" + responseWriteFile;
                }
                else
                {

                    string tmp = services.Local.readfiletxt(ref errReadFile, ref responseReadFile, mypathF);
                    if (string.IsNullOrEmpty(tmp))
                    {
                        richTextBox_Status.Text = mypathF + "\n Input Data is NULL!";
                    }
                    else if (!tmp.Equals(richTextBox_Send.Text))
                    {
                        richTextBox_Status.Text = "Data is not written" + responseReadFile;
                    }
                    else
                    {
                        richTextBox_Status.Text = "Write successfully to" + mypathF + "\n" + responseWriteFile;
                    }
                }
            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            richTextBox_Status.Text = null;
            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this,"The filename is empty!","ATTENTION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_path.Text))
                    mypathF = textBox_filename.Text;
                else
                    mypathF = textBox_path.Text + "\\" + textBox_filename.Text;
                
                richTextBox_Receive.Text = services.Local.readfiletxt(ref errReadFile, ref responseWriteFile, mypathF);
                
                if (errReadFile)
                {
                    errReadFile = false;
                    richTextBox_Status.Text = "Error while Reading data from file \n" + responseWriteFile;
                }
                else
                {
                    if (string.IsNullOrEmpty(richTextBox_Receive.Text))
                        richTextBox_Status.Text = mypathF + "\n has no data";
                    else 
                        richTextBox_Status.Text = mypathF + "\nRead data successfully";
                }
            }
        }   
        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_path.Text = null;
            textBox_filename.Text = null;
            richTextBox_Send.Text = null;
            richTextBox_Receive.Text = null;
            richTextBox_Status.Text = null;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Send.Text = null;
            richTextBox_Receive.Text = null;
            richTextBox_Status.Text = null;
            
            if (string.IsNullOrEmpty(textBox_path.Text))
                mypath = textBox_filename.Text;
            else
                mypath = textBox_path.Text + "/" + textBox_filename.Text;

            if (string.IsNullOrEmpty(textBox_filename.Text))
            {
                MessageBox.Show(this, "The filename is empty!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("The filename is empty!");
            }
            else if (!File.Exists(mypath))
            {
                richTextBox_Status.Text = mypath+"\nCannot clear!";
                MessageBox.Show(this, "File is not exist!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                services.Local.writetofiletxt(ref errWriteFile, ref responseWriteFile, "", mypath);
                //richTextBox_Status.Text = responseWriteFile;

                if (errWriteFile)
                {
                    errWriteFile = false;
                    richTextBox_Status.Text = "Error while Clearing data of file \n" + responseWriteFile;
                }
                else
                {

                    string tmp = services.Local.readfiletxt(ref errReadFile, ref responseReadFile, mypath);
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        richTextBox_Status.Text = "Cannot clear! \n" + responseReadFile + "\n" + responseWriteFile;
                    }
                    else
                    {
                        richTextBox_Status.Text = "Clear successfully data of " + mypath;
                    }
                }
            }
        }

        //public string errorWEB;
        //public bool errorW = false;
        public string Datares = null;
        public bool ErrRes = false;
        public string MessRes = null;
        private void but_check_Click(object sender, EventArgs e)
        {
            //System.Threading.Timer timer = new System.Threading.Timer(timeoutfunc, this, 0, 18000);
            richTextBox_WEBstt.Text = "";
            CONTROL.Services services = new CONTROL.Services();

            /*if (textBox_port.Text == "")
                richTextBox_WEBstt.Text = "Error : No information!";
            else
            {*/
            string url = null;
            if (string.IsNullOrEmpty(textBox_port.Text))
                url = uri_request.Text;
            else
                url = uri_request.Text + ":" + textBox_port.Text + "/";

            //Console.WriteLine(tmpurl);
            if (url == "")
            {
                richTextBox_WEBstt.Text = "Error connection ";
                MessageBox.Show("The URL is missing!");
                //errorW = true;
            }
            else
            {
                string tmpurl = url.Remove(5, url.Length - 5);
                if (tmpurl == "https")
                    Datares = services.Network.POSTHTTPS(ref errorW, ref errorWEB, url,
                            "Request", "Requesting");
                else
                    Datares = services.Network.POST(ref errorW, ref errorWEB, url,
                            "Request", "Requesting");
            }
            if (!string.IsNullOrEmpty(uri_request.Text))
            {
                if (errorW)
                {
                    richTextBox_WEBstt.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox_WEBstt.Text = "Error connection : " + url;
                    MessageBox.Show(this, errorWEB, "Server : " + url, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    services.Network.showresponse(mypathappWEB, Datares, uri_request.Text, ref ErrRes, ref MessRes, ref Datares);
                    if (ErrRes)
                        MessageBox.Show(MessRes);
                    else
                        richTextBox_WEBstt.Text = Datares;
                }
            }
        }

        private void button_request_Click(object sender, EventArgs e)
        {
            string url = null;
            if (string.IsNullOrEmpty(textBox_port.Text))
                url = uri_request.Text;
            else
                url = uri_request.Text + ":" + textBox_port.Text + "/";
            
            MyWebRequest myreq = new MyWebRequest();
            string refex = null;
            myreq.MyWebRequest1(url, "POST", "Hello");
            richTextBox_WEBstt.Text = myreq.GetResponse(ref refex);
            MessageBox.Show(refex);

        }

        bool errex = false;
        string exmess = null;
        private void button_Demo_Click(object sender, EventArgs e)
        {
            richTextBox_WEBstt.Text = "";
 /*           string response = null;
            services.Network.DemocpListener(textBox_IP.Text, Convert.ToInt32(textBox_port.Text),ref response,ref errex, ref exmess);
            if (errex)
            {
                errex = false;
                MessageBox.Show(exmess);
            }
            else 
            {
                richTextBox_WEBstt.Text = response;
            }*/

          
            try
            {
                string url = null;
                if (string.IsNullOrEmpty(textBox_port.Text))
                    url = uri_request.Text;
                else
                    url = uri_request.Text + ":" + textBox_port.Text + "/";

                WebClient client = new WebClient();
                string Datares = client.DownloadString(url);
                services.Network.showresponse(mypathappWEB, Datares, uri_request.Text, ref ErrRes, ref MessRes, ref Datares);
                if (ErrRes)
                    MessageBox.Show(MessRes);
                else
                    richTextBox_WEBstt.Text = Datares;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error Connection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button_resetW_Click(object sender, EventArgs e)
        {
            uri_request.Text = "http://localhost";
            textBox_IP.Text = "";
            textBox_port.Text = "8000";
            richTextBox_WEBstt.Text = "";
        }

        private void button_DemoCOM1_Click(object sender, EventArgs e)
        {
            services.Local.demoCOM();
        }

        private void checkBox_DEV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DEV.Checked)
                richTextBox_CheckBox.Text = "Choosing DEVICE";
            else
                richTextBox_CheckBox.Text = "Choosing USER";
        }

        private void button_ResetCB_Click(object sender, EventArgs e)
        {
            checkBox_DEV.Checked = false;
            richTextBox_CheckBox.Text = string.Empty;
        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {
            // Change the state of the form's controls
            // If the port is open, send focus to the send data box
            bool error = false;

            if (errorCOM)
            {
                InitializeControlValues();
                if (errorCOM)
                {
                    //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                    textBox_sttCOM.Text = "No COMport!";
                    cmB_COMport.Items.Clear();
                    cmB_Baud.Items.Clear();
                    cmB_Parity.Items.Clear();
                    cmB_COMport.Items.AddRange(new Object[] { });
                    cmB_Baud.Items.AddRange(new Object[] { });
                    cmB_Parity.Items.AddRange(new Object[] { });
                    MessageBox.Show(this, "Please insert device", "ERROR DEVICE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Console.WriteLine("no COM!");
                }
                else
                {
                    cmB_Baud.Items.AddRange(new object[] {
                        "300",
                        "600",
                        "1200",
                        "2400",
                        "4800",
                        "9600",
                        "14400",
                        "28800",
                        "36000",
                        "115000"});
                    /*cmB_Parity.Items.AddRange(new object[] {
                        "NONE",
                        "EVEN",
                        "ODD"});*/
                    textBox_sttCOM.Text = "";
                }
            }
            else if (errorCONN)
            {
                errorCONN = false;
                MessageBox.Show(this, "Could not open the COM port.\n Please turn off another device", "ERROR CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((cmB_Parity.Text == "") || (cmB_Baud.Text == ""))
            {
                error = true;
                InitializeControlValues();
                if (!errorCOM)
                {
                    MessageBox.Show(this, "None parameter! \nPlease select available options!", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    /*cmB_Baud.Items.AddRange(new object[] {
                        "300",
                        "600",
                        "1200",
                        "2400",
                        "4800",
                        "9600",
                        "14400",
                        "28800",
                        "36000",
                        "115000"});*/
                }
                else
                {
                    //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                    textBox_sttCOM.Text = "No COMport!";
                    cmB_COMport.Items.Clear(); cmB_COMport.Items.AddRange(new Object[] { });
                    cmB_Baud.Items.Clear(); cmB_Baud.Items.AddRange(new Object[] { });
                    cmB_Parity.Items.Clear(); cmB_Parity.Items.AddRange(new Object[] { });
                    MessageBox.Show(this, "Please insert device", "ERROR DEVICE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Console.WriteLine("no COM!");
                }
            }
            else
            {
                // If the port is open, close it.
                if (serialPortRFID.IsOpen)
                {
                    try
                    {
                        serialPortRFID.Close();
                        but_OpenPort.BackColor = System.Drawing.Color.AliceBlue;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        errorCONN = true;
                        MessageBox.Show(this, "Could not open the COM port.\n Please turn off another device", "ERROR CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    lb_stt.Text = "RFID_code";
                    but_OpenPort.Text = "Open port";
                    //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                    textBox_sttCOM.Text = "COMPort is Closed!";

                    //Console.WriteLine("COMport is closed ...");
                }
                else
                {
                    try
                    {
                        // Set the port's settings
                        serialPortRFID.BaudRate = int.Parse(cmB_Baud.Text);
                        serialPortRFID.DataBits = int.Parse(cmbDataBits.Text);
                        serialPortRFID.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                        serialPortRFID.Parity = (Parity)Enum.Parse(typeof(Parity), cmB_Parity.Text);
                        serialPortRFID.PortName = cmB_COMport.Text;

                        // Open the port
                        serialPortRFID.Open();
                    }

                    catch (UnauthorizedAccessException) { error = true; errorCONN = true; }
                    catch (IOException) { error = true; errorCOM = true; }
                    catch (ArgumentException) { error = true; }

                    if (errorCOM)
                    {
                        but_OpenPort.Text = "Open port";
                        //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                        textBox_sttCOM.Text = "No COMport!";

                        cmB_COMport.Items.Clear();
                        cmB_Baud.Items.Clear();
                        cmB_Parity.Items.Clear();
                        cmB_COMport.Items.AddRange(new Object[] { });
                        cmB_Baud.Items.AddRange(new Object[] { });
                        cmB_Parity.Items.AddRange(new Object[] { });
                        MessageBox.Show(this, "Please insert device", "ERROR DEVICE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        serialPortRFID.Close();
                    }
                    else if (errorCONN)
                    {
                        errorCONN = false;
                        MessageBox.Show(this, "Could not open the COM port.\n Please turn off another device", "ERROR CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (error)
                    {
                        but_OpenPort.Text = "Open port";
                        //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                        textBox_sttCOM.Text = "COMPort is Closed!";
                        MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        serialPortRFID.Close();
                    }
                    /*else
                {
                    // Show the initial pin states
                    UpdatePinState();
                    chkDTR.Checked = serialPortLAB_MANAGER.DtrEnable;
                    chkRTS.Checked = serialPortLAB_MANAGER.RtsEnable;
                }*/
                    else
                    {
                        txt_S = "";
                        but_OpenPort.Text = "Close port";
                        //textBox_sttCOM.SelectionAlignment = HorizontalAlignment.Center;
                        textBox_sttCOM.Text = "COMPort is Opened!";
                        //Console.WriteLine("COMport is opened ...");
                        but_OpenPort.BackColor = System.Drawing.Color.AntiqueWhite;
                    }
                }
            }
        }

        private void button_SaveCONF_Click(object sender, EventArgs e)
        {
            string localpath = "configCOM.txt";                 // ten path de luu file config COM

            if (string.IsNullOrEmpty(cmB_COMport.Text)
              || string.IsNullOrEmpty(cmB_Baud.Text)
              || string.IsNullOrEmpty(cmB_Parity.Text))
            {
                richTextBox_ResCOM.Text = "Cannot save configuration!";
                MessageBox.Show(this, "Input data is missing!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (serialPortRFID.IsOpen)
            {
                string datain = label_COMport.Text + ":" + cmB_COMport.Text + "\n" +
                                label_Baud.Text + ":" + cmB_Baud.Text + "\n" +
                                label_Parity.Text + ":" + cmB_Parity.Text;
                services.Local.writeCONF(ref errWriteFile, ref responseWriteFile, datain, localpath,ref responseReadFile);
                richTextBox_ResCOM.Text = responseWriteFile;
                richTextBox_Status.Text = responseReadFile;
            }
            else
            {
                richTextBox_ResCOM.Text = "Cannot save configuration!";
                MessageBox.Show(this, "Save configuration when Opening!", "COMport is Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_ResetCOM_Click(object sender, EventArgs e)
        {
            textBox_sttCOM.Text = "No COMport!";
            cmB_COMport.Items.Clear();
            cmB_Baud.Items.Clear();
            cmB_Parity.Items.Clear();
            cmB_COMport.Items.AddRange(new Object[] { });
            cmB_Baud.Items.AddRange(new Object[] { });
            cmB_Parity.Items.AddRange(new Object[] { });
            but_OpenPort.Text = "Open port";
            but_OpenPort.BackColor = System.Drawing.Color.AliceBlue;
            serialPortRFID.Close();
            errorCOM = true;
        }

        private void button_LoadCONF_Click(object sender, EventArgs e)
        {
            string localpath = "configCOM.txt";                             // ten path de luu file config COM

            if (errorCOM)                                                   // khi COM bi loi thi khong duoc load
            {
                richTextBox_Status.Text = "Cannot read " + localpath;
                richTextBox_ResCOM.Text = "Cannot load configuration!";
                MessageBox.Show(this, "Load configuration when Availble!", "COMport is not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (serialPortRFID.IsOpen)                                      // khi COMport dang mo thi khong duoc load
            {
                richTextBox_ResCOM.Text = "Cannot load configuration!";
                MessageBox.Show(this, "Load configuration when Closed!", "COMport is opening", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string dataCONF = services.Local.readfiletxt(ref errReadFile, ref responseWriteFile, localpath);    // lay data de config

                if (errReadFile)
                {
                    errReadFile = false;
                    richTextBox_Status.Text = "Error while Reading data from file \n" + responseWriteFile;
                }
                else
                {
                    services.Local.readCONF(dataCONF, ref label_Baud, ref cmB_Baud, ref label_Parity, ref cmB_Parity);
                    richTextBox_Status.Text = localpath + "\nRead data CONFIGURATION successfully";
                }
            }
        }

        #endregion Button Clicks
    }
}
