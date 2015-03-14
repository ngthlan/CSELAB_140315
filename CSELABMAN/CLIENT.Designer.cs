namespace CSELABMAN
{
    partial class CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENT));
            this.button_try = new System.Windows.Forms.Button();
            this.button_Detail = new System.Windows.Forms.Button();
            this.button_BORROW_RETURN = new System.Windows.Forms.Button();
            this.button_but_CONFIG = new System.Windows.Forms.Button();
            this.button_DEVICE = new System.Windows.Forms.Button();
            this.button_USER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_try
            // 
            this.button_try.BackColor = System.Drawing.SystemColors.Control;
            this.button_try.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_try.Image = global::CSELABMAN.Properties.Resources._try;
            this.button_try.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_try.Location = new System.Drawing.Point(229, 173);
            this.button_try.Name = "button_try";
            this.button_try.Size = new System.Drawing.Size(211, 155);
            this.button_try.TabIndex = 29;
            this.button_try.Text = "KIỂM TRA CHỨC NĂNG";
            this.button_try.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_try.UseVisualStyleBackColor = false;
            this.button_try.Click += new System.EventHandler(this.button_try_Click);
            // 
            // button_Detail
            // 
            this.button_Detail.BackColor = System.Drawing.SystemColors.Control;
            this.button_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Detail.Image = global::CSELABMAN.Properties.Resources.about;
            this.button_Detail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Detail.Location = new System.Drawing.Point(446, 173);
            this.button_Detail.Name = "button_Detail";
            this.button_Detail.Size = new System.Drawing.Size(211, 154);
            this.button_Detail.TabIndex = 28;
            this.button_Detail.Text = "THÔNG TIN PHẦN MỀM";
            this.button_Detail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Detail.UseVisualStyleBackColor = false;
            this.button_Detail.Click += new System.EventHandler(this.button_Detail_Click);
            // 
            // button_BORROW_RETURN
            // 
            this.button_BORROW_RETURN.BackColor = System.Drawing.SystemColors.Control;
            this.button_BORROW_RETURN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_BORROW_RETURN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_BORROW_RETURN.Image = ((System.Drawing.Image)(resources.GetObject("button_BORROW_RETURN.Image")));
            this.button_BORROW_RETURN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_BORROW_RETURN.Location = new System.Drawing.Point(446, 12);
            this.button_BORROW_RETURN.Name = "button_BORROW_RETURN";
            this.button_BORROW_RETURN.Size = new System.Drawing.Size(211, 154);
            this.button_BORROW_RETURN.TabIndex = 7;
            this.button_BORROW_RETURN.Text = "MƯỢN/TRẢ THIẾT BỊ";
            this.button_BORROW_RETURN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_BORROW_RETURN.UseVisualStyleBackColor = false;
            this.button_BORROW_RETURN.Click += new System.EventHandler(this.button_BORROW_RETURN_Click);
            // 
            // button_but_CONFIG
            // 
            this.button_but_CONFIG.BackColor = System.Drawing.SystemColors.Control;
            this.button_but_CONFIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_but_CONFIG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_but_CONFIG.Image = global::CSELABMAN.Properties.Resources.but_CONFIG;
            this.button_but_CONFIG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_but_CONFIG.Location = new System.Drawing.Point(12, 173);
            this.button_but_CONFIG.Name = "button_but_CONFIG";
            this.button_but_CONFIG.Size = new System.Drawing.Size(211, 154);
            this.button_but_CONFIG.TabIndex = 6;
            this.button_but_CONFIG.Text = "KIỂM TRA SERVER";
            this.button_but_CONFIG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_but_CONFIG.UseVisualStyleBackColor = false;
            this.button_but_CONFIG.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_DEVICE
            // 
            this.button_DEVICE.BackColor = System.Drawing.SystemColors.Control;
            this.button_DEVICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_DEVICE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DEVICE.Image = ((System.Drawing.Image)(resources.GetObject("button_DEVICE.Image")));
            this.button_DEVICE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_DEVICE.Location = new System.Drawing.Point(229, 12);
            this.button_DEVICE.Name = "button_DEVICE";
            this.button_DEVICE.Size = new System.Drawing.Size(211, 155);
            this.button_DEVICE.TabIndex = 2;
            this.button_DEVICE.Text = "QUẢN LÝ THIẾT BỊ";
            this.button_DEVICE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_DEVICE.UseVisualStyleBackColor = false;
            this.button_DEVICE.Click += new System.EventHandler(this.button_DEVICE_Click);
            // 
            // button_USER
            // 
            this.button_USER.BackColor = System.Drawing.SystemColors.Control;
            this.button_USER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_USER.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_USER.Image = ((System.Drawing.Image)(resources.GetObject("button_USER.Image")));
            this.button_USER.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_USER.Location = new System.Drawing.Point(12, 12);
            this.button_USER.Name = "button_USER";
            this.button_USER.Size = new System.Drawing.Size(211, 155);
            this.button_USER.TabIndex = 1;
            this.button_USER.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.button_USER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_USER.UseVisualStyleBackColor = false;
            this.button_USER.Click += new System.EventHandler(this.button_USER_Click);
            // 
            // CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.Controls.Add(this.button_try);
            this.Controls.Add(this.button_Detail);
            this.Controls.Add(this.button_BORROW_RETURN);
            this.Controls.Add(this.button_but_CONFIG);
            this.Controls.Add(this.button_DEVICE);
            this.Controls.Add(this.button_USER);
            this.Name = "CLIENT";
            this.Text = "QUẢN LÝ THẺ RFID - PTN KỸ THUẬT MÁY TÍNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CLIEN_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_USER;
        private System.Windows.Forms.Button button_DEVICE;
        private System.Windows.Forms.Button button_but_CONFIG;
        private System.Windows.Forms.Button button_BORROW_RETURN;
        private System.Windows.Forms.Button button_Detail;
        private System.Windows.Forms.Button button_try;
    }
}