using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Pink;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Purple;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }
    }
}
