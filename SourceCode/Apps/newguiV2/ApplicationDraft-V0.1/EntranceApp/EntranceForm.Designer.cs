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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStartWC = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.webCamTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 970);
            this.panel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(4, 4);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 52);
            this.homeBtn.TabIndex = 54;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
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
            this.checkinBtn.Location = new System.Drawing.Point(15, 110);
            this.checkinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(207, 91);
            this.checkinBtn.TabIndex = 9;
            this.checkinBtn.Text = " Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 110);
            this.sideHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(13, 91);
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
            this.monitorBtn.Location = new System.Drawing.Point(15, 252);
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 91);
            this.monitorBtn.TabIndex = 10;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 12);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.checkinHistoryBtn);
            this.checkinPanel.Controls.Add(this.userDetailsBtn);
            this.checkinPanel.Controls.Add(this.labelEntrance);
            this.checkinPanel.Controls.Add(this.checkinOverrideBtn);
            this.checkinPanel.Controls.Add(this.checkinInfoLbx);
            this.checkinPanel.Controls.Add(this.checkinMessageLbl);
            this.checkinPanel.Controls.Add(this.checkinStatusLbl);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.buttonStartWC);
            this.checkinPanel.Controls.Add(this.pictureBoxSource);
            this.checkinPanel.Location = new System.Drawing.Point(229, 70);
            this.checkinPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1473, 918);
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
            this.checkinHistoryBtn.Location = new System.Drawing.Point(384, 830);
            this.checkinHistoryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinHistoryBtn.Name = "checkinHistoryBtn";
            this.checkinHistoryBtn.Size = new System.Drawing.Size(231, 64);
            this.checkinHistoryBtn.TabIndex = 65;
            this.checkinHistoryBtn.Text = "Check History";
            this.checkinHistoryBtn.UseVisualStyleBackColor = false;
            this.checkinHistoryBtn.Click += new System.EventHandler(this.checkinHistoryBtn_Click);
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
            this.userDetailsBtn.Location = new System.Drawing.Point(105, 831);
            this.userDetailsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userDetailsBtn.Name = "userDetailsBtn";
            this.userDetailsBtn.Size = new System.Drawing.Size(231, 64);
            this.userDetailsBtn.TabIndex = 64;
            this.userDetailsBtn.Text = "Visitor Details";
            this.userDetailsBtn.UseVisualStyleBackColor = false;
            this.userDetailsBtn.Click += new System.EventHandler(this.userDetailsBtn_Click);
            // 
            // labelEntrance
            // 
            this.labelEntrance.AutoSize = true;
            this.labelEntrance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEntrance.Location = new System.Drawing.Point(85, 21);
            this.labelEntrance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntrance.Name = "labelEntrance";
            this.labelEntrance.Size = new System.Drawing.Size(207, 54);
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
            this.checkinOverrideBtn.Location = new System.Drawing.Point(884, 830);
            this.checkinOverrideBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinOverrideBtn.Name = "checkinOverrideBtn";
            this.checkinOverrideBtn.Size = new System.Drawing.Size(231, 64);
            this.checkinOverrideBtn.TabIndex = 58;
            this.checkinOverrideBtn.Text = "Override";
            this.checkinOverrideBtn.UseVisualStyleBackColor = false;
            this.checkinOverrideBtn.Click += new System.EventHandler(this.checkinOverrideBtn_Click);
            // 
            // checkinInfoLbx
            // 
            this.checkinInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinInfoLbx.FormattingEnabled = true;
            this.checkinInfoLbx.ItemHeight = 28;
            this.checkinInfoLbx.Location = new System.Drawing.Point(96, 487);
            this.checkinInfoLbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinInfoLbx.Name = "checkinInfoLbx";
            this.checkinInfoLbx.Size = new System.Drawing.Size(1019, 312);
            this.checkinInfoLbx.TabIndex = 57;
            // 
            // checkinMessageLbl
            // 
            this.checkinMessageLbl.AutoSize = true;
            this.checkinMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkinMessageLbl.ForeColor = System.Drawing.Color.Gray;
            this.checkinMessageLbl.Location = new System.Drawing.Point(453, 335);
            this.checkinMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinMessageLbl.Name = "checkinMessageLbl";
            this.checkinMessageLbl.Size = new System.Drawing.Size(106, 25);
            this.checkinMessageLbl.TabIndex = 55;
            this.checkinMessageLbl.Text = "(message)";
            // 
            // checkinStatusLbl
            // 
            this.checkinStatusLbl.AutoSize = true;
            this.checkinStatusLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinStatusLbl.Location = new System.Drawing.Point(589, 288);
            this.checkinStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinStatusLbl.Name = "checkinStatusLbl";
            this.checkinStatusLbl.Size = new System.Drawing.Size(120, 32);
            this.checkinStatusLbl.TabIndex = 56;
            this.checkinStatusLbl.Text = "(OK/NOK)";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lbCheckIn.Location = new System.Drawing.Point(643, 116);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(102, 28);
            this.lbCheckIn.TabIndex = 37;
            this.lbCheckIn.Text = "Ticket info";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(452, 288);
            this.labelStatusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(99, 32);
            this.labelStatusIn.TabIndex = 20;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(449, 116);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 153);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
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
            this.buttonStartWC.Location = new System.Drawing.Point(96, 382);
            this.buttonStartWC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartWC.Name = "buttonStartWC";
            this.buttonStartWC.Size = new System.Drawing.Size(284, 64);
            this.buttonStartWC.TabIndex = 3;
            this.buttonStartWC.Text = "Start QR Scanner";
            this.buttonStartWC.UseVisualStyleBackColor = false;
            this.buttonStartWC.Click += new System.EventHandler(this.buttonStartWC_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(96, 116);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(284, 244);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
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
            this.label1.Location = new System.Drawing.Point(253, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "Event Entrance";
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
            this.searchPanel.Location = new System.Drawing.Point(235, 74);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1473, 918);
            this.searchPanel.TabIndex = 34;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagRbtn.Location = new System.Drawing.Point(392, 151);
            this.tagRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(90, 32);
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
            this.checkoutLogsBtn.Location = new System.Drawing.Point(621, 779);
            this.checkoutLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(241, 58);
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
            this.checkinLogsBtn.Location = new System.Drawing.Point(348, 779);
            this.checkinLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(241, 58);
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
            this.viewLogsBtn.Location = new System.Drawing.Point(69, 780);
            this.viewLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(241, 58);
            this.viewLogsBtn.TabIndex = 44;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = false;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 28;
            this.logsInfoLbx.Location = new System.Drawing.Point(73, 206);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(961, 536);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // ticketRbtn
            // 
            this.ticketRbtn.AutoSize = true;
            this.ticketRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketRbtn.Location = new System.Drawing.Point(264, 151);
            this.ticketRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketRbtn.Name = "ticketRbtn";
            this.ticketRbtn.Size = new System.Drawing.Size(111, 32);
            this.ticketRbtn.TabIndex = 38;
            this.ticketRbtn.TabStop = true;
            this.ticketRbtn.Text = "Ticket Nr";
            this.ticketRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRbtn.Location = new System.Drawing.Point(163, 151);
            this.nameRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(85, 32);
            this.nameRbtn.TabIndex = 39;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(68, 154);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(80, 28);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(63, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 54);
            this.label4.TabIndex = 33;
            this.label4.Text = "LOGS";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(496, 146);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(461, 39);
            this.textBoxSearch.TabIndex = 30;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(48, 90);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 29;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(977, 146);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 41);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 970);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntranceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.panel1.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
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
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button buttonStartWC;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Button checkinOverrideBtn;
        private System.Windows.Forms.Label checkinMessageLbl;
        private System.Windows.Forms.Label checkinStatusLbl;
        private System.Windows.Forms.Label labelEntrance;
        private System.Windows.Forms.ListBox checkinInfoLbx;
        private System.Windows.Forms.Button checkinHistoryBtn;
        private System.Windows.Forms.Button userDetailsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.RadioButton tagRbtn;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton ticketRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button homeBtn;
    }
}

