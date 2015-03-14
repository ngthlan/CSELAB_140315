namespace CSELABMAN.VIEW
{
    partial class DETAIL
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
            this.button_Intro = new System.Windows.Forms.Button();
            this.richText_Stt = new System.Windows.Forms.RichTextBox();
            this.button_DetFunc = new System.Windows.Forms.Button();
            this.button_Ver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Intro
            // 
            this.button_Intro.BackColor = System.Drawing.Color.Beige;
            this.button_Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Intro.Location = new System.Drawing.Point(15, 17);
            this.button_Intro.Name = "button_Intro";
            this.button_Intro.Size = new System.Drawing.Size(92, 27);
            this.button_Intro.TabIndex = 0;
            this.button_Intro.Text = "Giới thiệu";
            this.button_Intro.UseVisualStyleBackColor = false;
            this.button_Intro.Click += new System.EventHandler(this.button_Intro_Click);
            // 
            // richText_Stt
            // 
            this.richText_Stt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.richText_Stt.Location = new System.Drawing.Point(124, 17);
            this.richText_Stt.Name = "richText_Stt";
            this.richText_Stt.ReadOnly = true;
            this.richText_Stt.Size = new System.Drawing.Size(294, 215);
            this.richText_Stt.TabIndex = 13;
            this.richText_Stt.Text = "";
            // 
            // button_DetFunc
            // 
            this.button_DetFunc.BackColor = System.Drawing.Color.Beige;
            this.button_DetFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_DetFunc.Location = new System.Drawing.Point(15, 77);
            this.button_DetFunc.Name = "button_DetFunc";
            this.button_DetFunc.Size = new System.Drawing.Size(92, 27);
            this.button_DetFunc.TabIndex = 14;
            this.button_DetFunc.Text = "Chức năng";
            this.button_DetFunc.UseVisualStyleBackColor = false;
            this.button_DetFunc.Click += new System.EventHandler(this.button_DetFunc_Click);
            // 
            // button_Ver
            // 
            this.button_Ver.BackColor = System.Drawing.Color.Beige;
            this.button_Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Ver.Location = new System.Drawing.Point(15, 139);
            this.button_Ver.Name = "button_Ver";
            this.button_Ver.Size = new System.Drawing.Size(92, 27);
            this.button_Ver.TabIndex = 15;
            this.button_Ver.Text = "Phiên bản";
            this.button_Ver.UseVisualStyleBackColor = false;
            this.button_Ver.Click += new System.EventHandler(this.button_Ver_Click);
            // 
            // DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(430, 245);
            this.Controls.Add(this.button_Ver);
            this.Controls.Add(this.button_DetFunc);
            this.Controls.Add(this.richText_Stt);
            this.Controls.Add(this.button_Intro);
            this.Name = "DETAIL";
            this.Text = "CHI TIẾT PHẦN MỀM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Intro;
        private System.Windows.Forms.RichTextBox richText_Stt;
        private System.Windows.Forms.Button button_DetFunc;
        private System.Windows.Forms.Button button_Ver;
    }
}