﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
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

        private void btnstd_Click(object sender, EventArgs e)
        {
            MngStd frm = new MngStd();
            frm.ShowDialog();
        }

        private void btndept_Click(object sender, EventArgs e)
        {
            MngDept frm = new MngDept();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MngCrs frm = new MngCrs();
            frm.ShowDialog();
        }
    }
}
