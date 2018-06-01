﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class HomeForm : Form
    {
        Form selectedForm;

        public HomeForm()
        {
            InitializeComponent();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Dispose();
            Program.home.Show(); // return to login
        }

        private void visitorBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new VisitorForm();
            selectedForm.Show();
            this.Dispose();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new ShopForm();
            selectedForm.Show();
            this.Dispose();
        }

        private void campBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new CampForm();
            selectedForm.Show();
            this.Dispose();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new StockForm();
            selectedForm.Show();
            this.Dispose();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

        }

        private void analyticBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new AnalyticForm();
            selectedForm.Show();
            this.Dispose();
        }
    }
}
