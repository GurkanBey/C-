using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Adiniz:"+textBox1.Text);
            listBox1.Items.Add("Soyadiniz:" + textBox2.Text);
            listBox1.Items.Add("TC:" + maskedTextBox1.Text);
            listBox1.Items.Add("Telefon:" + maskedTextBox2.Text);

            double sinav1, sinav2, sinav3, sinav4, sinav5, ortalama;
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            sinav3 = Convert.ToDouble(textBox5.Text);
            sinav4 = Convert.ToDouble(textBox6.Text);
            sinav5 = Convert.ToDouble(textBox7.Text);

            ortalama = (sinav1 + sinav2 + sinav3 + sinav4 + sinav5) / 5;
            listBox2.Items.Add("Ortalamaniz:" + ortalama);


            //Char degisken tanimlama da boyle
            char takim;
            takim = 'H';
            label12.Text = takim.ToString();
        }
    }
}
