using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = hScrollBar3.Value.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = hScrollBar1.Value;
            int g = hScrollBar2.Value;
            int b = hScrollBar3.Value;

            label4.BackColor = Color.FromArgb(r, g, b);
            panel3.BackColor = Color.FromArgb(r, g, b);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
