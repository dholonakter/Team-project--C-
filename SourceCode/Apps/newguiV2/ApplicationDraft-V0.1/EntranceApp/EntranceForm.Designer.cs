﻿namespace EntranceApp
{
    partial class EntranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.checkinHistoryBtn = new System.Windows.Forms.Button();
            this.userDetailsBtn = new System.Windows.Forms.Button();
            this.labelEntrance = new System.Windows.Forms.Label();
            this.checkinOverrideBtn = new System.Windows.Forms.Button();
            this.checkinInfoLbx = new System.Windows.Forms.ListBox();
            this.checkinMessageLbl = new System.Windows.Forms.Label();
            this.checkinStatusLbl = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.buttonStartWC = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.checkoutOverrideBtn = new System.Windows.Forms.Button();
            this.checkoutDetailsBtn = new System.Windows.Forms.Button();
            this.checkoutInfoLbx = new System.Windows.Forms.ListBox();
            this.checkoutMessageLbl = new System.Windows.Forms.Label();
            this.checkoutStatusLbl = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.tagRbtn = new System.Windows.Forms.RadioButton();
            this.checkoutLogsBtn = new System.Windows.Forms.Button();
            this.checkinLogsBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.ticketRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.searchLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.webCamTimer = new System.Windows.Forms.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirmPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 788);
            this.panel1.TabIndex = 0;
            // 
            // checkinBtn
            // 
            this.checkinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.White;
            this.checkinBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBtn.Image")));
            this.checkinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBtn.Location = new System.Drawing.Point(11, 89);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(155, 74);
            this.checkinBtn.TabIndex = 9;
            this.checkinBtn.Text = " Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(10, 74);
            this.sideHighlight.TabIndex = 14;
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(11, 296);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 74);
            this.monitorBtn.TabIndex = 10;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBtn.Image")));
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(11, 191);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(155, 74);
            this.checkoutBtn.TabIndex = 11;
            this.checkoutBtn.Text = "    Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 10);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.buttonConfirmPayment);
            this.checkinPanel.Controls.Add(this.checkinHistoryBtn);
            this.checkinPanel.Controls.Add(this.userDetailsBtn);
            this.checkinPanel.Controls.Add(this.labelEntrance);
            this.checkinPanel.Controls.Add(this.checkinOverrideBtn);
            this.checkinPanel.Controls.Add(this.checkinInfoLbx);
            this.checkinPanel.Controls.Add(this.checkinMessageLbl);
            this.checkinPanel.Controls.Add(this.checkinStatusLbl);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.buttonStartWC);
            this.checkinPanel.Controls.Add(this.pictureBoxSource);
            this.checkinPanel.Location = new System.Drawing.Point(197, 54);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1375, 948);
            this.checkinPanel.TabIndex = 3;
            // 
            // checkinHistoryBtn
            // 
            this.checkinHistoryBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinHistoryBtn.Enabled = false;
            this.checkinHistoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinHistoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinHistoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkinHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.checkinHistoryBtn.Location = new System.Drawing.Point(283, 638);
            this.checkinHistoryBtn.Name = "checkinHistoryBtn";
            this.checkinHistoryBtn.Size = new System.Drawing.Size(173, 61);
            this.checkinHistoryBtn.TabIndex = 65;
            this.checkinHistoryBtn.Text = "Check History";
            this.checkinHistoryBtn.UseVisualStyleBackColor = false;
            // 
            // userDetailsBtn
            // 
            this.userDetailsBtn.BackColor = System.Drawing.Color.DimGray;
            this.userDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userDetailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.userDetailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.userDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDetailsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.userDetailsBtn.Location = new System.Drawing.Point(76, 638);
            this.userDetailsBtn.Name = "userDetailsBtn";
            this.userDetailsBtn.Size = new System.Drawing.Size(173, 61);
            this.userDetailsBtn.TabIndex = 64;
            this.userDetailsBtn.Text = "Visitor Details";
            this.userDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // labelEntrance
            // 
            this.labelEntrance.AutoSize = true;
            this.labelEntrance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEntrance.Location = new System.Drawing.Point(68, 41);
            this.labelEntrance.Name = "labelEntrance";
            this.labelEntrance.Size = new System.Drawing.Size(167, 45);
            this.labelEntrance.TabIndex = 62;
            this.labelEntrance.Text = "CHECK IN";
            // 
            // checkinOverrideBtn
            // 
            this.checkinOverrideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkinOverrideBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.checkinOverrideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.checkinOverrideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.checkinOverrideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinOverrideBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinOverrideBtn.ForeColor = System.Drawing.Color.White;
            this.checkinOverrideBtn.Location = new System.Drawing.Point(491, 638);
            this.checkinOverrideBtn.Name = "checkinOverrideBtn";
            this.checkinOverrideBtn.Size = new System.Drawing.Size(173, 61);
            this.checkinOverrideBtn.TabIndex = 58;
            this.checkinOverrideBtn.Text = "Override";
            this.checkinOverrideBtn.UseVisualStyleBackColor = false;
            this.checkinOverrideBtn.Click += new System.EventHandler(this.checkinOverrideBtn_Click);
            // 
            // checkinInfoLbx
            // 
            this.checkinInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinInfoLbx.FormattingEnabled = true;
            this.checkinInfoLbx.ItemHeight = 21;
            this.checkinInfoLbx.Location = new System.Drawing.Point(76, 447);
            this.checkinInfoLbx.Name = "checkinInfoLbx";
            this.checkinInfoLbx.Size = new System.Drawing.Size(952, 172);
            this.checkinInfoLbx.TabIndex = 57;
            // 
            // checkinMessageLbl
            // 
            this.checkinMessageLbl.AutoSize = true;
            this.checkinMessageLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.checkinMessageLbl.Location = new System.Drawing.Point(324, 315);
            this.checkinMessageLbl.Name = "checkinMessageLbl";
            this.checkinMessageLbl.Size = new System.Drawing.Size(81, 21);
            this.checkinMessageLbl.TabIndex = 55;
            this.checkinMessageLbl.Text = "(message)";
            // 
            // checkinStatusLbl
            // 
            this.checkinStatusLbl.AutoSize = true;
            this.checkinStatusLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinStatusLbl.Location = new System.Drawing.Point(426, 290);
            this.checkinStatusLbl.Name = "checkinStatusLbl";
            this.checkinStatusLbl.Size = new System.Drawing.Size(95, 25);
            this.checkinStatusLbl.TabIndex = 56;
            this.checkinStatusLbl.Text = "(OK/NOK)";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lbCheckIn.Location = new System.Drawing.Point(324, 156);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(99, 25);
            this.lbCheckIn.TabIndex = 37;
            this.lbCheckIn.Text = "Ticket info";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(323, 290);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(81, 25);
            this.labelStatusIn.TabIndex = 20;
            this.labelStatusIn.Text = "STATUS";
            // 
            // buttonStartWC
            // 
            this.buttonStartWC.BackColor = System.Drawing.Color.DimGray;
            this.buttonStartWC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartWC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonStartWC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonStartWC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartWC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartWC.ForeColor = System.Drawing.Color.White;
            this.buttonStartWC.Location = new System.Drawing.Point(76, 370);
            this.buttonStartWC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartWC.Name = "buttonStartWC";
            this.buttonStartWC.Size = new System.Drawing.Size(213, 60);
            this.buttonStartWC.TabIndex = 3;
            this.buttonStartWC.Text = "Start QR Scanner";
            this.buttonStartWC.UseVisualStyleBackColor = false;
            this.buttonStartWC.Click += new System.EventHandler(this.buttonStartWC_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(76, 154);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(213, 198);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.labelExit);
            this.checkoutPanel.Controls.Add(this.checkoutOverrideBtn);
            this.checkoutPanel.Controls.Add(this.checkoutDetailsBtn);
            this.checkoutPanel.Controls.Add(this.checkoutInfoLbx);
            this.checkoutPanel.Controls.Add(this.checkoutMessageLbl);
            this.checkoutPanel.Controls.Add(this.checkoutStatusLbl);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Location = new System.Drawing.Point(197, 54);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1260, 936);
            this.checkoutPanel.TabIndex = 4;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelExit.Location = new System.Drawing.Point(68, 44);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(198, 45);
            this.labelExit.TabIndex = 63;
            this.labelExit.Text = "CHECK OUT";
            // 
            // checkoutOverrideBtn
            // 
            this.checkoutOverrideBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutOverrideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutOverrideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutOverrideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkoutOverrideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutOverrideBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutOverrideBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutOverrideBtn.Location = new System.Drawing.Point(283, 606);
            this.checkoutOverrideBtn.Name = "checkoutOverrideBtn";
            this.checkoutOverrideBtn.Size = new System.Drawing.Size(172, 54);
            this.checkoutOverrideBtn.TabIndex = 47;
            this.checkoutOverrideBtn.Text = "Override";
            this.checkoutOverrideBtn.UseVisualStyleBackColor = false;
            this.checkoutOverrideBtn.Click += new System.EventHandler(this.checkoutOverrideBtn_Click);
            // 
            // checkoutDetailsBtn
            // 
            this.checkoutDetailsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutDetailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutDetailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkoutDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutDetailsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutDetailsBtn.Location = new System.Drawing.Point(75, 606);
            this.checkoutDetailsBtn.Name = "checkoutDetailsBtn";
            this.checkoutDetailsBtn.Size = new System.Drawing.Size(181, 54);
            this.checkoutDetailsBtn.TabIndex = 49;
            this.checkoutDetailsBtn.Text = "Visitor details";
            this.checkoutDetailsBtn.UseVisualStyleBackColor = false;
            this.checkoutDetailsBtn.Click += new System.EventHandler(this.checkoutDetailsBtn_Click);
            // 
            // checkoutInfoLbx
            // 
            this.checkoutInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutInfoLbx.FormattingEnabled = true;
            this.checkoutInfoLbx.ItemHeight = 21;
            this.checkoutInfoLbx.Location = new System.Drawing.Point(76, 233);
            this.checkoutInfoLbx.Name = "checkoutInfoLbx";
            this.checkoutInfoLbx.Size = new System.Drawing.Size(892, 340);
            this.checkoutInfoLbx.TabIndex = 46;
            // 
            // checkoutMessageLbl
            // 
            this.checkoutMessageLbl.AutoSize = true;
            this.checkoutMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkoutMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.checkoutMessageLbl.Location = new System.Drawing.Point(71, 182);
            this.checkoutMessageLbl.Name = "checkoutMessageLbl";
            this.checkoutMessageLbl.Size = new System.Drawing.Size(84, 20);
            this.checkoutMessageLbl.TabIndex = 43;
            this.checkoutMessageLbl.Text = "(message)";
            // 
            // checkoutStatusLbl
            // 
            this.checkoutStatusLbl.AutoSize = true;
            this.checkoutStatusLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutStatusLbl.Location = new System.Drawing.Point(152, 153);
            this.checkoutStatusLbl.Name = "checkoutStatusLbl";
            this.checkoutStatusLbl.Size = new System.Drawing.Size(95, 25);
            this.checkoutStatusLbl.TabIndex = 44;
            this.checkoutStatusLbl.Text = "(OK/NOK)";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(71, 153);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(81, 25);
            this.labelStatusOut.TabIndex = 2;
            this.labelStatusOut.Text = "STATUS";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.tagRbtn);
            this.searchPanel.Controls.Add(this.checkoutLogsBtn);
            this.searchPanel.Controls.Add(this.checkinLogsBtn);
            this.searchPanel.Controls.Add(this.viewLogsBtn);
            this.searchPanel.Controls.Add(this.logsInfoLbx);
            this.searchPanel.Controls.Add(this.ticketRbtn);
            this.searchPanel.Controls.Add(this.nameRbtn);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.textBoxSearch);
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Location = new System.Drawing.Point(197, 54);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1395, 936);
            this.searchPanel.TabIndex = 5;
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagRbtn.Location = new System.Drawing.Point(322, 154);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(73, 25);
            this.tagRbtn.TabIndex = 45;
            this.tagRbtn.TabStop = true;
            this.tagRbtn.Text = "Tag Nr";
            this.tagRbtn.UseVisualStyleBackColor = true;
            // 
            // checkoutLogsBtn
            // 
            this.checkoutLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkoutLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutLogsBtn.Location = new System.Drawing.Point(491, 579);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(181, 54);
            this.checkoutLogsBtn.TabIndex = 42;
            this.checkoutLogsBtn.Text = "Checked Out";
            this.checkoutLogsBtn.UseVisualStyleBackColor = false;
            this.checkoutLogsBtn.Click += new System.EventHandler(this.checkoutLogsBtn_Click);
            // 
            // checkinLogsBtn
            // 
            this.checkinLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkinLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkinLogsBtn.Location = new System.Drawing.Point(283, 579);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(181, 54);
            this.checkinLogsBtn.TabIndex = 43;
            this.checkinLogsBtn.Text = "Checked In";
            this.checkinLogsBtn.UseVisualStyleBackColor = false;
            this.checkinLogsBtn.Click += new System.EventHandler(this.checkinLogsBtn_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogsBtn.ForeColor = System.Drawing.Color.White;
            this.viewLogsBtn.Location = new System.Drawing.Point(76, 579);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(181, 54);
            this.viewLogsBtn.TabIndex = 44;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = false;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 17;
            this.logsInfoLbx.Location = new System.Drawing.Point(76, 207);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(1029, 344);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // ticketRbtn
            // 
            this.ticketRbtn.AutoSize = true;
            this.ticketRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketRbtn.Location = new System.Drawing.Point(226, 154);
            this.ticketRbtn.Name = "ticketRbtn";
            this.ticketRbtn.Size = new System.Drawing.Size(90, 25);
            this.ticketRbtn.TabIndex = 38;
            this.ticketRbtn.TabStop = true;
            this.ticketRbtn.Text = "Ticket Nr";
            this.ticketRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRbtn.Location = new System.Drawing.Point(150, 154);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(70, 25);
            this.nameRbtn.TabIndex = 39;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(71, 152);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(76, 25);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(68, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 45);
            this.label4.TabIndex = 33;
            this.label4.Text = "LOGS";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(400, 150);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 33);
            this.textBoxSearch.TabIndex = 30;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(36, 73);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 22);
            this.labelMonitor.TabIndex = 29;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(657, 150);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(48, 33);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // webCamTimer
            // 
            this.webCamTimer.Tick += new System.EventHandler(this.webCamTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(200, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Larp Festival";
            // 
            // buttonConfirmPayment
            // 
            this.buttonConfirmPayment.BackColor = System.Drawing.Color.Green;
            this.buttonConfirmPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmPayment.Image")));
            this.buttonConfirmPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmPayment.Location = new System.Drawing.Point(901, 370);
            this.buttonConfirmPayment.Name = "buttonConfirmPayment";
            this.buttonConfirmPayment.Size = new System.Drawing.Size(127, 60);
            this.buttonConfirmPayment.TabIndex = 66;
            this.buttonConfirmPayment.Text = "Payment";
            this.buttonConfirmPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmPayment.UseVisualStyleBackColor = false;
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntranceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.panel1.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button buttonStartWC;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Button checkinOverrideBtn;
        private System.Windows.Forms.Label checkinMessageLbl;
        private System.Windows.Forms.Label checkinStatusLbl;
        private System.Windows.Forms.Button checkoutOverrideBtn;
        private System.Windows.Forms.Button checkoutDetailsBtn;
        private System.Windows.Forms.ListBox checkoutInfoLbx;
        private System.Windows.Forms.Label checkoutMessageLbl;
        private System.Windows.Forms.Label checkoutStatusLbl;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton ticketRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton tagRbtn;
        private System.Windows.Forms.Label labelEntrance;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ListBox checkinInfoLbx;
        private System.Windows.Forms.Button checkinHistoryBtn;
        private System.Windows.Forms.Button userDetailsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirmPayment;
    }
}

