﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CookImplement.Dialog
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string exception, string target)
        {
            InitializeComponent();
            textBox1.Text += target;
            textBox1.Text += "\n" + exception;
            this.lLink.Text = Application.CompanyName;
            this.lVersion.Text = "v" + this.ProductVersion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show(CookImplement.Properties.Resources.MsgCopied, CookImplement.Properties.Resources.StrInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
