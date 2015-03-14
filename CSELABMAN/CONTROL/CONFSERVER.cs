using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSELABMAN.CONTROL
{
    public partial class CONFSERVER : Form
    {
        // cac bien tham so
        public string errorWEB;
        public bool errorW = false;
        public bool ckcOK = false;
        public string sttpostHTTPS;
        public string errorHTTPS;
        public string mypathapp = null;

        public CONFSERVER(string path)
        {
            InitializeComponent();
            mypathapp = path;
        }

        #region Local Methods
        private CLIENT ParentVIEW;
        public void setparentadd(CLIENT parentview)
        {
            this.ParentVIEW = parentview;
        }
     

        private void CONFSERVER_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!ckcOK)
                {
                    DialogResult result = MessageBox.Show("Bạn thật sự không muốn thiết lập kết nối?", "Tắt thiết lập", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        e.Cancel = false;
                        //parentVIEW.setaddress("", false);
                        //Environment.Exit(1);
                        //this.Close();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        
        
        #endregion Local Methods

        #region Button_Click
        public char[] tmpchar = {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        //public string tmpstringrespone = null;
        public string Datares = null;
        public bool ErrRes = false;
        public string MessRes = null;
        private void but_check_Click(object sender, EventArgs e)
        {
            //System.Threading.Timer timer = new System.Threading.Timer(timeoutfunc, this, 0, 18000);
            richText_Stt.Text = "";
            CONTROL.Services services = new CONTROL.Services();
            
            /*if (textBox_port.Text == "")
                richText_Stt.Text = "Error : No information!";
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
                richText_Stt.Text = "Error connection ";
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
                    richText_Stt.SelectionAlignment = HorizontalAlignment.Center;
                    richText_Stt.Text = "Error connection : " + url;
                    MessageBox.Show(this, errorWEB, "Server : " + url, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    services.Network.showresponse(mypathapp, Datares, uri_request.Text,ref ErrRes, ref MessRes, ref Datares);
                    if (ErrRes)
                        MessageBox.Show(MessRes);
                    else
                        richText_Stt.Text = Datares;
                }
            }
        }

        /*public void timeoutfunc(object state)
        {
            //throw new TimeoutException();
            MessageBox.Show(this, "Connection timed out", "Error");
        }*/

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (richText_Stt.Text == "OK" || richText_Stt.Text == "Connected successfully")
            {
                ckcOK = true;
                /*if (apptype == "USER")
                {
                    ParentUSER.setaddress(uri_request.Text, true);
                    MessageBox.Show(this, "Địa chỉ máy chủ là "+uri_request.Text, "QUẢN LÝ NGƯỜI DÙNG");
                }
                else if (apptype == "DEV")
                {
                    ParentDEV.setaddress(uri_request.Text, true);
                    MessageBox.Show(this, "Địa chỉ máy chủ là " + uri_request.Text, "QUẢN LÝ THIẾT BỊ");
                }
                else if (apptype == "MAN")
                {
                    ParentMAN.setaddress(uri_request.Text, true);
                    MessageBox.Show(this, "Địa chỉ máy chủ là " + uri_request.Text, "MƯỢN/TRẢ THIẾT BỊ");
                }
                else if (apptype == "TEST")
                {*/
                    MessageBox.Show(this, "Địa chỉ máy chủ là " + uri_request.Text, "KIỂM TRA THÀNH CÔNG");
                    //this.Close();
                /*}
                else 
                {
                    RFIDMAN frmMAN = new RFIDMAN(mypathapp);
                    frmMAN.setaddress(uri_request.Text, true);
                    MessageBox.Show(this, "Địa chỉ máy chủ là " + uri_request.Text, "MƯỢN/TRẢ THIẾT BỊ");
                    frmMAN.Show();
                }
                */
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "Vui lòng kiểm tra URL của server trước khi kết nối", "Kết nối bị lỗi", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.Retry)
                {
                    richText_Stt.Text = "Không thể kết nối \n "+uri_request.Text;
                }
                else
                {
                    richText_Stt.Text = "Chưa thiết lập server";
                    this.Close();
                }
            }

            
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            richText_Stt.SelectionAlignment = HorizontalAlignment.Center;
            richText_Stt.Text = "OK";
        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            uri_request.Clear();
            textBox_port.Clear();
            richText_Stt.Clear();
        }

        #endregion Button_Click

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void uri_request_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_url_Click(object sender, EventArgs e)
        {

        }

        private void label_port_Click(object sender, EventArgs e)
        {

        }
        
    }
}
