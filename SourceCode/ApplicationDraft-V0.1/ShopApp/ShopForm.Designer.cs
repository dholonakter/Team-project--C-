﻿namespace ShopApp
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.overviewBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkRbtn = new System.Windows.Forms.RadioButton();
            this.foodRbtn = new System.Windows.Forms.RadioButton();
            this.quantitySelec = new System.Windows.Forms.NumericUpDown();
            this.startPanel = new System.Windows.Forms.Panel();
            this.lblCardLinkedStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.overviewBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 640);
            this.panel1.TabIndex = 0;
            // 
            // overviewBtn
            // 
            this.overviewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overviewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.overviewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.overviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBtn.ForeColor = System.Drawing.Color.White;
            this.overviewBtn.Image = ((System.Drawing.Image)(resources.GetObject("overviewBtn.Image")));
            this.overviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overviewBtn.Location = new System.Drawing.Point(11, 89);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(155, 54);
            this.overviewBtn.TabIndex = 15;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
            // 
            // productBtn
            // 
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(11, 181);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(155, 54);
            this.productBtn.TabIndex = 17;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 10);
            this.panel2.TabIndex = 1;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.lblCardLinkedStatus);
            this.productPanel.Controls.Add(this.labelOrderInfo);
            this.productPanel.Controls.Add(this.itemLbx);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.drinkRbtn);
            this.productPanel.Controls.Add(this.foodRbtn);
            this.productPanel.Controls.Add(this.quantitySelec);
            this.productPanel.Location = new System.Drawing.Point(230, 70);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(997, 634);
            this.productPanel.TabIndex = 4;
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrderInfo.Location = new System.Drawing.Point(508, 97);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(17, 23);
            this.labelOrderInfo.TabIndex = 28;
            this.labelOrderInfo.Text = "-";
            // 
            // itemLbx
            // 
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.Location = new System.Drawing.Point(59, 136);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(330, 160);
            this.itemLbx.TabIndex = 26;
            this.itemLbx.SelectedIndexChanged += new System.EventHandler(this.itemLbx_SelectedIndexChanged);
            this.itemLbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemLbx_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose Type :";
            // 
            // drinkRbtn
            // 
            this.drinkRbtn.AutoSize = true;
            this.drinkRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkRbtn.Location = new System.Drawing.Point(336, 97);
            this.drinkRbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drinkRbtn.Name = "drinkRbtn";
            this.drinkRbtn.Size = new System.Drawing.Size(57, 20);
            this.drinkRbtn.TabIndex = 24;
            this.drinkRbtn.Text = "Drink";
            this.drinkRbtn.UseVisualStyleBackColor = true;
            // 
            // foodRbtn
            // 
            this.foodRbtn.AutoSize = true;
            this.foodRbtn.Checked = true;
            this.foodRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodRbtn.Location = new System.Drawing.Point(242, 96);
            this.foodRbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foodRbtn.Name = "foodRbtn";
            this.foodRbtn.Size = new System.Drawing.Size(58, 20);
            this.foodRbtn.TabIndex = 23;
            this.foodRbtn.TabStop = true;
            this.foodRbtn.Text = "Food";
            this.foodRbtn.UseVisualStyleBackColor = true;
            this.foodRbtn.CheckedChanged += new System.EventHandler(this.foodRbtn_CheckedChanged);
            // 
            // quantitySelec
            // 
            this.quantitySelec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitySelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelec.Location = new System.Drawing.Point(172, 314);
            this.quantitySelec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantitySelec.Name = "quantitySelec";
            this.quantitySelec.Size = new System.Drawing.Size(92, 22);
            this.quantitySelec.TabIndex = 19;
            this.quantitySelec.ValueChanged += new System.EventHandler(this.quantitySelec_ValueChanged);
            // 
            // startPanel
            // 
            this.startPanel.Location = new System.Drawing.Point(219, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1105, 687);
            this.startPanel.TabIndex = 9;
            // 
            // lblCardLinkedStatus
            // 
            this.lblCardLinkedStatus.AutoSize = true;
            this.lblCardLinkedStatus.Location = new System.Drawing.Point(56, 391);
            this.lblCardLinkedStatus.Name = "lblCardLinkedStatus";
            this.lblCardLinkedStatus.Size = new System.Drawing.Size(88, 13);
            this.lblCardLinkedStatus.TabIndex = 31;
            this.lblCardLinkedStatus.Text = "...........................";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.RadioButton drinkRbtn;
        private System.Windows.Forms.RadioButton foodRbtn;
        private System.Windows.Forms.NumericUpDown quantitySelec;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label lblCardLinkedStatus;
    }
}

