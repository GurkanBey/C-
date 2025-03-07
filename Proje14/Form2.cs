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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb1 = new Araba();

            rb1.renk = "Yesil";
            rb1.hiz = 1230;
            rb1.motor = 425.2;
            rb1.fiyat = 2322;
            rb1.durum = 'B';

            label1.Text = rb1.renk;
            label2.Text = rb1.hiz.ToString();
            label3.Text = rb1.motor.ToString();
            label4.Text = rb1.fiyat.ToString();
            label5.Text = rb1.durum.ToString();
        }
    }
}
