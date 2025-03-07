using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje8
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 9; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <=10 ; i++)
            {
                toplam = toplam + i;
                listBox2.Items.Add(toplam);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam2 = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    toplam2 = toplam2 + i;
                    listBox3.Items.Add(toplam2);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= sayi; i++)
            {
                listBox4.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    listBox5.Items.Add(i);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int carpim = 1;
            int sayi3 = Convert.ToInt32(textBox3.Text);
            for (int i = 1; i <= sayi3; i++)
            {
                carpim = carpim * i;
                listBox6.Items.Add(carpim);
            }
        }
    }
}
