﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiGet
{
    public partial class addHeaderForm : Form
    {
        private string headerName = "";
        private string headerValue = "";

        public addHeaderForm()
        {
            InitializeComponent();
        }

        public string getHeaderName()
        {
            return this.headerName;
        }

        public string getHeaderValue()
        {
            return this.headerValue;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            headerName = nameTbx.Text;
            headerValue = valueTbx.Text;
            this.Close();
        }
    }
}
