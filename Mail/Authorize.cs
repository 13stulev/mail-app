﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void logginig_Click(object sender, EventArgs e)
        {

            Form1.Login = textLogin.Text;
            Form1.Password = textPassword.Text;
            Form1.Port = textPort.Text;
            Form1.Host = textHost.Text;

            this.Close();
        }

        private void Authorize_Load(object sender, EventArgs e)
        {

        }
    }
}
