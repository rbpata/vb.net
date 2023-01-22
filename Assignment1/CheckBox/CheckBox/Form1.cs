using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true )
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Bold);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,FontStyle.Italic);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,  FontStyle.Underline);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size,FontStyle.Regular);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
