﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntranceApp
{
    public partial class EntranceForm : Form
    {
        //Participant p;

        public EntranceForm()
        {
            InitializeComponent();
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
            ticketPanel.BringToFront();
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
            ticketPanel.BringToFront();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();
        }
    }
}
