using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSELABMAN
{
    public partial class CLIENT : Form
    {
        public CLIENT()
        {
            InitializeComponent();
        }

        public static string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create);
        string mypathapp = mydocpath + @"\Response.html";


        #region Local Methods
        private void CLIEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "Tắt chương trình", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    /*Process[] myproc = Process.GetProcessesByName("firefox");
                    foreach (Process tmppro in myproc)
                    {
                        tmppro.Kill();
                    }*/
                    //myproc.has;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
            //MessageBox.Show("\n End Thread");

        }

        #endregion Local Methods
        
        #region Button Clicks
        private void button_USER_Click(object sender, EventArgs e)
        {

        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            VIEW.DETAIL frmDetail = new VIEW.DETAIL();
            frmDetail.Show();
        }

        private void button_DEVICE_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            CONTROL.CONFSERVER frmCONF = new CONTROL.CONFSERVER(mypathapp);
            frmCONF.setparentadd(this);
            frmCONF.Show();
        }

        private void button_BORROW_RETURN_Click(object sender, EventArgs e)
        {

        }

        private void button_try_Click(object sender, EventArgs e)
        {
            CSELABMAN.CONTROL.TRY frmTRY = new CSELABMAN.CONTROL.TRY();
            frmTRY.Show();
        }
        #endregion Button Clicks
    }
}
