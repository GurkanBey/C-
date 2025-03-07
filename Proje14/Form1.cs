using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje14
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Mavi";
            rb.hiz = 123;
            rb.motor = 455.2;
            rb.fiyat = 2222;
            rb.durum = 'A';
            rb.YIL = -2015;
            rb.MARKA = "bmw";
            rb.muayene = 2017;
            rb.plaka = "abcdaf";
            rb.sahip = "Ahmet";
            

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A");
        }
    }
}
