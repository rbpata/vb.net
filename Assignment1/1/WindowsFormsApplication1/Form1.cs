using System;
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
        int no1, no2,ans;
        private void button1_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt16(textBox1.Text);
            no2 = Convert.ToInt16(textBox2.Text);
            ans = no1 + no2;
            textBox3.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt16(textBox1.Text);
            no2 = Convert.ToInt16(textBox2.Text);
            ans = no1 - no2;
            textBox3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt16(textBox1.Text);
            no2 = Convert.ToInt16(textBox2.Text);
            ans = no1 * no2;
            textBox3.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt16(textBox1.Text);
            no2 = Convert.ToInt16(textBox2.Text);
            ans = no1 / no2;
            textBox3.Text = ans.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        
    }
}
