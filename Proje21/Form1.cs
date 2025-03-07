using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje21
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point konum = new Point();
            Random rnd1 = new Random();
            int sayi1, sayi2;
            sayi1 = rnd1.Next(1, 1400);
            sayi2 = rnd1.Next(1, 650);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            konum.X = sayi1;
            konum.Y = sayi2;
            pictureBox1.Location = konum;

        }
    }
}
