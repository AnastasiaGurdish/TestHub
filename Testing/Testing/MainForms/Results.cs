﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Results : Form
    {
        int result;
        public Results(int result)
        {
            InitializeComponent();
            this.result = result;
            ResultBox.Text = Convert.ToString(result);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}