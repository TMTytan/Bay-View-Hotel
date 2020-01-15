﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay_View_Hotel
{
    public partial class Staff_View : Form
    {
        public Staff_View()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Login();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Bookings();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Customers();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Reports();
            newForm.Show();
        }
    }
}
