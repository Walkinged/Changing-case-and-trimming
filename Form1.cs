﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringvar = textBox1.Text;
            textBox1.Text = stringvar.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringtrim = textBox1.Text;
            int stringlen = stringtrim.Length;
            MessageBox.Show(stringlen.ToString());

            stringtrim = stringtrim.Trim();
            stringlen = stringtrim.Length;
            MessageBox.Show(stringlen.ToString());
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            string stringvar = textBox1.Text;

            if (stringvar.Contains(textBox2.Text))
            {
                MessageBox.Show("True");
            }
        }
    }
}
