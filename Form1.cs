﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestinSouceControle
{
    public partial class testing : Form
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        public testing()
        {
            InitializeComponent();
        }

        private void testing_Load(object sender, EventArgs e)
        {
            results();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            count1++;
            results();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            count1++;
            count2++;
            results();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            count1++;
            count2++;
            count3++;
            results();
        }
        public void results()
        {
           
            Lbcounter1.Text = count1.ToString();
            Lbcounter2.Text = count2.ToString();
            Lbcounter3.Text = count3.ToString();
        }
    }
}
