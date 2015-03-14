namespace CSELABMAN.CONTROL
{
    partial class CONFSERVER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_url = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.but_check = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.richText_Stt = new System.Windows.Forms.RichTextBox();
            this.groupBox_infor = new System.Windows.Forms.GroupBox();
            this.button_POSTS = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.uri_request = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox_infor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(1, 25);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(65, 13);
            this.label_url.TabIndex = 19;
            this.label_url.Text = "Địa chỉ URL";
            this.label_url.Click += new System.EventHandler(this.label_url_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(19, 52);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(32, 13);
            this.label_port.TabIndex = 21;
            this.label_port.Text = "Cổng";
            this.label_port.Click += new System.EventHandler(this.label_port_Click);
            // 
            // but_check
            // 
            this.but_check.Location = new System.Drawing.Point(9, 75);
            this.but_check.Name = "but_check";
            this.but_check.Size = new System.Drawing.Size(54, 22);
            this.but_check.TabIndex = 23;
            this.but_check.Text = "Kiểm tra";
            this.but_check.UseVisualStyleBackColor = true;
            this.but_check.Click += new System.EventHandler(this.but_check_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(178, 75);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(54, 22);
            this.button_Connect.TabIndex = 24;
            this.button_Connect.Text = "Kết nối";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // richText_Stt
            // 
            this.richText_Stt.Location = new System.Drawing.Point(6, 20);
            this.richText_Stt.Name = "richText_Stt";
            this.richText_Stt.ReadOnly = true;
            this.richText_Stt.Size = new System.Drawing.Size(144, 49);
            this.richText_Stt.TabIndex = 25;
            this.richText_Stt.Text = "";
            // 
            // groupBox_infor
            // 
            this.groupBox_infor.Controls.Add(this.button_POSTS);
            this.groupBox_infor.Controls.Add(this.textBox_port);
            this.groupBox_infor.Controls.Add(this.uri_request);
            this.groupBox_infor.Controls.Add(this.label_url);
            this.groupBox_infor.Controls.Add(this.button_Connect);
            this.groupBox_infor.Controls.Add(this.but_check);
            this.groupBox_infor.Controls.Add(this.label_port);
            this.groupBox_infor.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infor.Name = "groupBox_infor";
            this.groupBox_infor.Size = new System.Drawing.Size(245, 103);
            this.groupBox_infor.TabIndex = 26;
            this.groupBox_infor.TabStop = false;
            this.groupBox_infor.Text = "CÀI ĐẶT ";
            // 
            // button_POSTS
            // 
            this.button_POSTS.Location = new System.Drawing.Point(99, 75);
            this.button_POSTS.Name = "button_POSTS";
            this.button_POSTS.Size = new System.Drawing.Size(54, 22);
            this.button_POSTS.TabIndex = 28;
            this.button_POSTS.Text = "RESET";
            this.button_POSTS.UseVisualStyleBackColor = true;
            this.button_POSTS.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(72, 49);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(158, 20);
            this.textBox_port.TabIndex = 27;
            this.textBox_port.Text = "80";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // uri_request
            // 
            this.uri_request.Location = new System.Drawing.Point(72, 22);
            this.uri_request.Name = "uri_request";
            this.uri_request.Size = new System.Drawing.Size(158, 20);
            this.uri_request.TabIndex = 26;
            this.uri_request.Text = "http://localhost";
            this.uri_request.TextChanged += new System.EventHandler(this.uri_request_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richText_Stt);
            this.groupBox1.Location = new System.Drawing.Point(263, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRẠNG THÁI PHẢN HỒI";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(325, 93);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(37, 22);
            this.button_OK.TabIndex = 28;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // CONFSERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 127);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_infor);
            this.Name = "CONFSERVER";
            this.Text = "THIẾT LẬP MÁY CHỦ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CONFSERVER_FormClosing);
            this.groupBox_infor.ResumeLayout(false);
            this.groupBox_infor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Button but_check;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.RichTextBox richText_Stt;
        private System.Windows.Forms.GroupBox groupBox_infor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox uri_request;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_POSTS;
    }
}