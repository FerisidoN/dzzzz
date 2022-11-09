using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzzzz
{
    public partial class Form1 : Form
    {
        int R = 0, G = 0, B = 0;
        float start_size = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Text";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = radioButton2.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = radioButton1.Text;
            }
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

       

      

        private void trackBar3_Scroll_1(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            if (trackBar4.Value != 0)
            {
                start_size = trackBar4.Value;
                label1.Font = new Font(label1.Font.FontFamily, start_size, FontStyle.Regular);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
