namespace CSELABMAN.CONTROL
{
    partial class TRY
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
            this.components = new System.ComponentModel.Container();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.button_Write = new System.Windows.Forms.Button();
            this.label_Path = new System.Windows.Forms.Label();
            this.richTextBox_Send = new System.Windows.Forms.RichTextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_filename = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.groupBox_FILE = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_Send = new System.Windows.Forms.Label();
            this.button_Read = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_Status = new System.Windows.Forms.RichTextBox();
            this.label_Receive = new System.Windows.Forms.Label();
            this.richTextBox_Receive = new System.Windows.Forms.RichTextBox();
            this.groupBox_COM = new System.Windows.Forms.GroupBox();
            this.button_LoadCONF = new System.Windows.Forms.Button();
            this.button_ResetCOM = new System.Windows.Forms.Button();
            this.button_SaveCONF = new System.Windows.Forms.Button();
            this.lb_stt = new System.Windows.Forms.Label();
            this.label_RFID = new System.Windows.Forms.Label();
            this.richTextBox_ResCOM = new System.Windows.Forms.RichTextBox();
            this.label_sttCOM = new System.Windows.Forms.Label();
            this.textBox_sttCOM = new System.Windows.Forms.TextBox();
            this.cmB_Parity = new System.Windows.Forms.ComboBox();
            this.but_OpenPort = new System.Windows.Forms.Button();
            this.button_DemoCOM1 = new System.Windows.Forms.Button();
            this.label_Parity = new System.Windows.Forms.Label();
            this.label_COMport = new System.Windows.Forms.Label();
            this.cmB_Baud = new System.Windows.Forms.ComboBox();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.button_ResetCB = new System.Windows.Forms.Button();
            this.richTextBox_CheckBox = new System.Windows.Forms.RichTextBox();
            this.checkBox_DEV = new System.Windows.Forms.CheckBox();
            this.groupBox_Server = new System.Windows.Forms.GroupBox();
            this.button_resetW = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.button_Demo = new System.Windows.Forms.Button();
            this.button_request = new System.Windows.Forms.Button();
            this.richTextBox_WEBstt = new System.Windows.Forms.RichTextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.uri_request = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.but_check = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_FILE.SuspendLayout();
            this.groupBox_COM.SuspendLayout();
            this.groupBox_Select.SuspendLayout();
            this.groupBox_Server.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Location = new System.Drawing.Point(0, 0);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 0;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Location = new System.Drawing.Point(0, 0);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 0;
            // 
            // button_Write
            // 
            this.button_Write.BackColor = System.Drawing.SystemColors.Control;
            this.button_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_Write.Location = new System.Drawing.Point(13, 147);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(54, 23);
            this.button_Write.TabIndex = 29;
            this.button_Write.Text = "Write";
            this.button_Write.UseVisualStyleBackColor = false;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(17, 89);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(29, 13);
            this.label_Path.TabIndex = 30;
            this.label_Path.Text = "Path";
            // 
            // richTextBox_Send
            // 
            this.richTextBox_Send.Location = new System.Drawing.Point(13, 28);
            this.richTextBox_Send.Name = "richTextBox_Send";
            this.richTextBox_Send.Size = new System.Drawing.Size(142, 52);
            this.richTextBox_Send.TabIndex = 31;
            this.richTextBox_Send.Text = "";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(52, 86);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(103, 20);
            this.textBox_path.TabIndex = 32;
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Location = new System.Drawing.Point(15, 115);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(52, 13);
            this.label_filename.TabIndex = 33;
            this.label_filename.Text = "File name";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(73, 112);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(82, 20);
            this.textBox_filename.TabIndex = 34;
            this.textBox_filename.Text = "123.txt";
            // 
            // groupBox_FILE
            // 
            this.groupBox_FILE.Controls.Add(this.button_Clear);
            this.groupBox_FILE.Controls.Add(this.button_Reset);
            this.groupBox_FILE.Controls.Add(this.label_Send);
            this.groupBox_FILE.Controls.Add(this.button_Read);
            this.groupBox_FILE.Controls.Add(this.label_status);
            this.groupBox_FILE.Controls.Add(this.button_Write);
            this.groupBox_FILE.Controls.Add(this.richTextBox_Status);
            this.groupBox_FILE.Controls.Add(this.label_Receive);
            this.groupBox_FILE.Controls.Add(this.richTextBox_Receive);
            this.groupBox_FILE.Controls.Add(this.label_Path);
            this.groupBox_FILE.Controls.Add(this.richTextBox_Send);
            this.groupBox_FILE.Controls.Add(this.textBox_filename);
            this.groupBox_FILE.Controls.Add(this.textBox_path);
            this.groupBox_FILE.Controls.Add(this.label_filename);
            this.groupBox_FILE.Location = new System.Drawing.Point(12, 12);
            this.groupBox_FILE.Name = "groupBox_FILE";
            this.groupBox_FILE.Size = new System.Drawing.Size(327, 216);
            this.groupBox_FILE.TabIndex = 35;
            this.groupBox_FILE.TabStop = false;
            this.groupBox_FILE.Text = "FILE";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_Clear.Location = new System.Drawing.Point(13, 176);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(54, 23);
            this.button_Clear.TabIndex = 41;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_Reset.Location = new System.Drawing.Point(101, 176);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(54, 23);
            this.button_Reset.TabIndex = 37;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_Send
            // 
            this.label_Send.AutoSize = true;
            this.label_Send.Location = new System.Drawing.Point(63, 12);
            this.label_Send.Name = "label_Send";
            this.label_Send.Size = new System.Drawing.Size(32, 13);
            this.label_Send.TabIndex = 40;
            this.label_Send.Text = "Send";
            // 
            // button_Read
            // 
            this.button_Read.BackColor = System.Drawing.SystemColors.Control;
            this.button_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_Read.Location = new System.Drawing.Point(101, 147);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(54, 23);
            this.button_Read.TabIndex = 36;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = false;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(229, 112);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(37, 13);
            this.label_status.TabIndex = 39;
            this.label_status.Text = "Status";
            // 
            // richTextBox_Status
            // 
            this.richTextBox_Status.Location = new System.Drawing.Point(175, 128);
            this.richTextBox_Status.Name = "richTextBox_Status";
            this.richTextBox_Status.ReadOnly = true;
            this.richTextBox_Status.Size = new System.Drawing.Size(142, 71);
            this.richTextBox_Status.TabIndex = 38;
            this.richTextBox_Status.Text = "";
            // 
            // label_Receive
            // 
            this.label_Receive.AutoSize = true;
            this.label_Receive.Location = new System.Drawing.Point(229, 12);
            this.label_Receive.Name = "label_Receive";
            this.label_Receive.Size = new System.Drawing.Size(47, 13);
            this.label_Receive.TabIndex = 37;
            this.label_Receive.Text = "Receive";
            // 
            // richTextBox_Receive
            // 
            this.richTextBox_Receive.Location = new System.Drawing.Point(175, 28);
            this.richTextBox_Receive.Name = "richTextBox_Receive";
            this.richTextBox_Receive.ReadOnly = true;
            this.richTextBox_Receive.Size = new System.Drawing.Size(142, 74);
            this.richTextBox_Receive.TabIndex = 36;
            this.richTextBox_Receive.Text = "";
            // 
            // groupBox_COM
            // 
            this.groupBox_COM.Controls.Add(this.button_LoadCONF);
            this.groupBox_COM.Controls.Add(this.button_ResetCOM);
            this.groupBox_COM.Controls.Add(this.button_SaveCONF);
            this.groupBox_COM.Controls.Add(this.lb_stt);
            this.groupBox_COM.Controls.Add(this.label_RFID);
            this.groupBox_COM.Controls.Add(this.richTextBox_ResCOM);
            this.groupBox_COM.Controls.Add(this.label_sttCOM);
            this.groupBox_COM.Controls.Add(this.textBox_sttCOM);
            this.groupBox_COM.Controls.Add(this.cmB_Parity);
            this.groupBox_COM.Controls.Add(this.but_OpenPort);
            this.groupBox_COM.Controls.Add(this.button_DemoCOM1);
            this.groupBox_COM.Controls.Add(this.label_Parity);
            this.groupBox_COM.Controls.Add(this.label_COMport);
            this.groupBox_COM.Controls.Add(this.cmB_Baud);
            this.groupBox_COM.Controls.Add(this.cmB_COMport);
            this.groupBox_COM.Controls.Add(this.label_Baud);
            this.groupBox_COM.Location = new System.Drawing.Point(345, 12);
            this.groupBox_COM.Name = "groupBox_COM";
            this.groupBox_COM.Size = new System.Drawing.Size(327, 216);
            this.groupBox_COM.TabIndex = 36;
            this.groupBox_COM.TabStop = false;
            this.groupBox_COM.Text = "COM port";
            // 
            // button_LoadCONF
            // 
            this.button_LoadCONF.BackColor = System.Drawing.SystemColors.Control;
            this.button_LoadCONF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_LoadCONF.Location = new System.Drawing.Point(245, 71);
            this.button_LoadCONF.Name = "button_LoadCONF";
            this.button_LoadCONF.Size = new System.Drawing.Size(54, 23);
            this.button_LoadCONF.TabIndex = 54;
            this.button_LoadCONF.Text = "Load";
            this.button_LoadCONF.UseVisualStyleBackColor = false;
            this.button_LoadCONF.Click += new System.EventHandler(this.button_LoadCONF_Click);
            // 
            // button_ResetCOM
            // 
            this.button_ResetCOM.Location = new System.Drawing.Point(241, 100);
            this.button_ResetCOM.Name = "button_ResetCOM";
            this.button_ResetCOM.Size = new System.Drawing.Size(58, 22);
            this.button_ResetCOM.TabIndex = 53;
            this.button_ResetCOM.Text = "Reset";
            this.button_ResetCOM.UseVisualStyleBackColor = true;
            this.button_ResetCOM.Click += new System.EventHandler(this.button_ResetCOM_Click);
            // 
            // button_SaveCONF
            // 
            this.button_SaveCONF.BackColor = System.Drawing.SystemColors.Control;
            this.button_SaveCONF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_SaveCONF.Location = new System.Drawing.Point(181, 71);
            this.button_SaveCONF.Name = "button_SaveCONF";
            this.button_SaveCONF.Size = new System.Drawing.Size(54, 23);
            this.button_SaveCONF.TabIndex = 42;
            this.button_SaveCONF.Text = "Save";
            this.button_SaveCONF.UseVisualStyleBackColor = false;
            this.button_SaveCONF.Click += new System.EventHandler(this.button_SaveCONF_Click);
            // 
            // lb_stt
            // 
            this.lb_stt.AutoSize = true;
            this.lb_stt.Location = new System.Drawing.Point(85, 99);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(62, 13);
            this.lb_stt.TabIndex = 52;
            this.lb_stt.Text = "RFID_code";
            // 
            // label_RFID
            // 
            this.label_RFID.AutoSize = true;
            this.label_RFID.Location = new System.Drawing.Point(12, 99);
            this.label_RFID.Name = "label_RFID";
            this.label_RFID.Size = new System.Drawing.Size(56, 13);
            this.label_RFID.TabIndex = 51;
            this.label_RFID.Text = "RFIDcode";
            // 
            // richTextBox_ResCOM
            // 
            this.richTextBox_ResCOM.Location = new System.Drawing.Point(25, 128);
            this.richTextBox_ResCOM.Name = "richTextBox_ResCOM";
            this.richTextBox_ResCOM.ReadOnly = true;
            this.richTextBox_ResCOM.Size = new System.Drawing.Size(287, 71);
            this.richTextBox_ResCOM.TabIndex = 49;
            this.richTextBox_ResCOM.Text = "";
            // 
            // label_sttCOM
            // 
            this.label_sttCOM.AutoSize = true;
            this.label_sttCOM.Location = new System.Drawing.Point(163, 21);
            this.label_sttCOM.Name = "label_sttCOM";
            this.label_sttCOM.Size = new System.Drawing.Size(37, 13);
            this.label_sttCOM.TabIndex = 50;
            this.label_sttCOM.Text = "Status";
            // 
            // textBox_sttCOM
            // 
            this.textBox_sttCOM.Location = new System.Drawing.Point(206, 18);
            this.textBox_sttCOM.Name = "textBox_sttCOM";
            this.textBox_sttCOM.ReadOnly = true;
            this.textBox_sttCOM.Size = new System.Drawing.Size(106, 20);
            this.textBox_sttCOM.TabIndex = 49;
            // 
            // cmB_Parity
            // 
            this.cmB_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Parity.FormattingEnabled = true;
            this.cmB_Parity.Location = new System.Drawing.Point(67, 71);
            this.cmB_Parity.Name = "cmB_Parity";
            this.cmB_Parity.Size = new System.Drawing.Size(90, 21);
            this.cmB_Parity.TabIndex = 3;
            // 
            // but_OpenPort
            // 
            this.but_OpenPort.Location = new System.Drawing.Point(241, 45);
            this.but_OpenPort.Name = "but_OpenPort";
            this.but_OpenPort.Size = new System.Drawing.Size(71, 22);
            this.but_OpenPort.TabIndex = 25;
            this.but_OpenPort.Text = "Open Port";
            this.but_OpenPort.UseVisualStyleBackColor = true;
            this.but_OpenPort.Click += new System.EventHandler(this.but_OpenPort_Click);
            // 
            // button_DemoCOM1
            // 
            this.button_DemoCOM1.Location = new System.Drawing.Point(178, 44);
            this.button_DemoCOM1.Name = "button_DemoCOM1";
            this.button_DemoCOM1.Size = new System.Drawing.Size(57, 22);
            this.button_DemoCOM1.TabIndex = 48;
            this.button_DemoCOM1.Text = "Demo1";
            this.button_DemoCOM1.UseVisualStyleBackColor = true;
            this.button_DemoCOM1.Click += new System.EventHandler(this.button_DemoCOM1_Click);
            // 
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Location = new System.Drawing.Point(12, 75);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(33, 13);
            this.label_Parity.TabIndex = 7;
            this.label_Parity.Text = "Parity";
            // 
            // label_COMport
            // 
            this.label_COMport.AutoSize = true;
            this.label_COMport.Location = new System.Drawing.Point(12, 21);
            this.label_COMport.Name = "label_COMport";
            this.label_COMport.Size = new System.Drawing.Size(49, 13);
            this.label_COMport.TabIndex = 1;
            this.label_COMport.Text = "COMport";
            // 
            // cmB_Baud
            // 
            this.cmB_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Baud.FormattingEnabled = true;
            this.cmB_Baud.Items.AddRange(new object[] {
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
            this.cmB_Baud.Location = new System.Drawing.Point(67, 45);
            this.cmB_Baud.Name = "cmB_Baud";
            this.cmB_Baud.Size = new System.Drawing.Size(90, 21);
            this.cmB_Baud.TabIndex = 11;
            // 
            // cmB_COMport
            // 
            this.cmB_COMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_COMport.FormattingEnabled = true;
            this.cmB_COMport.Location = new System.Drawing.Point(67, 19);
            this.cmB_COMport.Name = "cmB_COMport";
            this.cmB_COMport.Size = new System.Drawing.Size(90, 21);
            this.cmB_COMport.TabIndex = 4;
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Location = new System.Drawing.Point(12, 48);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(32, 13);
            this.label_Baud.TabIndex = 5;
            this.label_Baud.Text = "Baud";
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.button_ResetCB);
            this.groupBox_Select.Controls.Add(this.richTextBox_CheckBox);
            this.groupBox_Select.Controls.Add(this.checkBox_DEV);
            this.groupBox_Select.Location = new System.Drawing.Point(345, 234);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(327, 198);
            this.groupBox_Select.TabIndex = 37;
            this.groupBox_Select.TabStop = false;
            this.groupBox_Select.Text = "SELECT";
            // 
            // button_ResetCB
            // 
            this.button_ResetCB.Location = new System.Drawing.Point(254, 72);
            this.button_ResetCB.Name = "button_ResetCB";
            this.button_ResetCB.Size = new System.Drawing.Size(58, 22);
            this.button_ResetCB.TabIndex = 48;
            this.button_ResetCB.Text = "Reset";
            this.button_ResetCB.UseVisualStyleBackColor = true;
            this.button_ResetCB.Click += new System.EventHandler(this.button_ResetCB_Click);
            // 
            // richTextBox_CheckBox
            // 
            this.richTextBox_CheckBox.Location = new System.Drawing.Point(25, 100);
            this.richTextBox_CheckBox.Name = "richTextBox_CheckBox";
            this.richTextBox_CheckBox.ReadOnly = true;
            this.richTextBox_CheckBox.Size = new System.Drawing.Size(287, 71);
            this.richTextBox_CheckBox.TabIndex = 48;
            this.richTextBox_CheckBox.Text = "";
            // 
            // checkBox_DEV
            // 
            this.checkBox_DEV.AutoSize = true;
            this.checkBox_DEV.Location = new System.Drawing.Point(15, 76);
            this.checkBox_DEV.Name = "checkBox_DEV";
            this.checkBox_DEV.Size = new System.Drawing.Size(48, 17);
            this.checkBox_DEV.TabIndex = 0;
            this.checkBox_DEV.Text = "DEV";
            this.checkBox_DEV.UseVisualStyleBackColor = true;
            this.checkBox_DEV.CheckedChanged += new System.EventHandler(this.checkBox_DEV_CheckedChanged);
            // 
            // groupBox_Server
            // 
            this.groupBox_Server.Controls.Add(this.button_resetW);
            this.groupBox_Server.Controls.Add(this.textBox_IP);
            this.groupBox_Server.Controls.Add(this.label_IP);
            this.groupBox_Server.Controls.Add(this.button_Demo);
            this.groupBox_Server.Controls.Add(this.button_request);
            this.groupBox_Server.Controls.Add(this.richTextBox_WEBstt);
            this.groupBox_Server.Controls.Add(this.textBox_port);
            this.groupBox_Server.Controls.Add(this.uri_request);
            this.groupBox_Server.Controls.Add(this.label_url);
            this.groupBox_Server.Controls.Add(this.but_check);
            this.groupBox_Server.Controls.Add(this.label_port);
            this.groupBox_Server.Location = new System.Drawing.Point(12, 234);
            this.groupBox_Server.Name = "groupBox_Server";
            this.groupBox_Server.Size = new System.Drawing.Size(327, 198);
            this.groupBox_Server.TabIndex = 38;
            this.groupBox_Server.TabStop = false;
            this.groupBox_Server.Text = "SERVER";
            // 
            // button_resetW
            // 
            this.button_resetW.Location = new System.Drawing.Point(232, 76);
            this.button_resetW.Name = "button_resetW";
            this.button_resetW.Size = new System.Drawing.Size(58, 22);
            this.button_resetW.TabIndex = 47;
            this.button_resetW.Text = "Reset";
            this.button_resetW.UseVisualStyleBackColor = true;
            this.button_resetW.Click += new System.EventHandler(this.button_resetW_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(52, 50);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(103, 20);
            this.textBox_IP.TabIndex = 46;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(17, 53);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(17, 13);
            this.label_IP.TabIndex = 45;
            this.label_IP.Text = "IP";
            // 
            // button_Demo
            // 
            this.button_Demo.Location = new System.Drawing.Point(93, 76);
            this.button_Demo.Name = "button_Demo";
            this.button_Demo.Size = new System.Drawing.Size(45, 22);
            this.button_Demo.TabIndex = 44;
            this.button_Demo.Text = "Demo";
            this.button_Demo.UseVisualStyleBackColor = true;
            this.button_Demo.Click += new System.EventHandler(this.button_Demo_Click);
            // 
            // button_request
            // 
            this.button_request.Location = new System.Drawing.Point(154, 76);
            this.button_request.Name = "button_request";
            this.button_request.Size = new System.Drawing.Size(58, 22);
            this.button_request.TabIndex = 43;
            this.button_request.Text = "Request";
            this.button_request.UseVisualStyleBackColor = true;
            this.button_request.Click += new System.EventHandler(this.button_request_Click);
            // 
            // richTextBox_WEBstt
            // 
            this.richTextBox_WEBstt.Location = new System.Drawing.Point(20, 104);
            this.richTextBox_WEBstt.Name = "richTextBox_WEBstt";
            this.richTextBox_WEBstt.ReadOnly = true;
            this.richTextBox_WEBstt.Size = new System.Drawing.Size(287, 71);
            this.richTextBox_WEBstt.TabIndex = 42;
            this.richTextBox_WEBstt.Text = "";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(218, 50);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(67, 20);
            this.textBox_port.TabIndex = 34;
            this.textBox_port.Text = "8000";
            // 
            // uri_request
            // 
            this.uri_request.Location = new System.Drawing.Point(52, 24);
            this.uri_request.Name = "uri_request";
            this.uri_request.Size = new System.Drawing.Size(233, 20);
            this.uri_request.TabIndex = 33;
            this.uri_request.Text = "http://localhost";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(17, 26);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(29, 13);
            this.label_url.TabIndex = 29;
            this.label_url.Text = "URL";
            // 
            // but_check
            // 
            this.but_check.Location = new System.Drawing.Point(20, 76);
            this.but_check.Name = "but_check";
            this.but_check.Size = new System.Drawing.Size(54, 22);
            this.but_check.TabIndex = 31;
            this.but_check.Text = "Kiểm tra";
            this.but_check.UseVisualStyleBackColor = true;
            this.but_check.Click += new System.EventHandler(this.but_check_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(187, 53);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(25, 13);
            this.label_port.TabIndex = 30;
            this.label_port.Text = "port";
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.PortName = "COM4";
            this.serialPortRFID.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRFID_DataReceived);
            // 
            // TRY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 449);
            this.Controls.Add(this.groupBox_Server);
            this.Controls.Add(this.groupBox_Select);
            this.Controls.Add(this.groupBox_COM);
            this.Controls.Add(this.groupBox_FILE);
            this.Name = "TRY";
            this.Text = "TRY";
            this.groupBox_FILE.ResumeLayout(false);
            this.groupBox_FILE.PerformLayout();
            this.groupBox_COM.ResumeLayout(false);
            this.groupBox_COM.PerformLayout();
            this.groupBox_Select.ResumeLayout(false);
            this.groupBox_Select.PerformLayout();
            this.groupBox_Server.ResumeLayout(false);
            this.groupBox_Server.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Button button_Write;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.RichTextBox richTextBox_Send;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.GroupBox groupBox_FILE;
        private System.Windows.Forms.Label label_Receive;
        private System.Windows.Forms.RichTextBox richTextBox_Receive;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_Status;
        private System.Windows.Forms.Label label_Send;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox_COM;
        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.GroupBox groupBox_Server;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox uri_request;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button but_check;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.RichTextBox richTextBox_WEBstt;
        private System.Windows.Forms.Button button_request;
        private System.Windows.Forms.Button button_Demo;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button button_resetW;
        private System.Windows.Forms.Button button_DemoCOM1;
        private System.Windows.Forms.ComboBox cmB_Parity;
        private System.Windows.Forms.Button but_OpenPort;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.Label label_COMport;
        private System.Windows.Forms.ComboBox cmB_Baud;
        private System.Windows.Forms.ComboBox cmB_COMport;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.CheckBox checkBox_DEV;
        private System.Windows.Forms.RichTextBox richTextBox_CheckBox;
        private System.Windows.Forms.Button button_ResetCB;
        private System.Windows.Forms.RichTextBox richTextBox_ResCOM;
        private System.Windows.Forms.Label label_sttCOM;
        private System.Windows.Forms.TextBox textBox_sttCOM;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.Label lb_stt;
        private System.Windows.Forms.Label label_RFID;
        private System.Windows.Forms.Button button_SaveCONF;
        private System.Windows.Forms.Button button_ResetCOM;
        private System.Windows.Forms.Button button_LoadCONF;
    }
}