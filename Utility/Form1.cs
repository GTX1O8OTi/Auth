﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bridge;

namespace Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Authenticator.LoginViaHWIDAsync();
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/GTX1O8OTi/Auth");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Authenticator.LoginViaCredientialsAsync(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }
        }
    }
}
