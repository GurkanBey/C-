using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        int soruno = 0, dogru = 0, yanlis = 0;

        private void btna_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            soruno++;
            labelno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kac yilinda kurulmusutur?";
                btna.Text = "1920";
                btnb.Text = "1923";
                btnc.Text = "1924";
                btnd.Text = "1925";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi sehir Akdeniz`de bulunmaz?";
                btna.Text = "Hatay";
                btnb.Text = "Ankara";
                btnc.Text = "Mersin";
                btnd.Text = "Adana";
                label4.Text = "Ankara";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Yuzuklerin efendisi kac kitaptir?";
                btna.Text = "1";
                btnb.Text = "4";
                btnc.Text = "3";
                btnd.Text = "12";
                label4.Text = "3";

            }
        }
    }
}
