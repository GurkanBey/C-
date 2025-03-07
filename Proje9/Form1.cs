using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1,toplam=0;
            while (i <= 10) 
            {
                listBox1.Items.Add("Merhabalar");
                listBox2.Items.Add(i);
                toplam = toplam + i;
                i ++;
                
                
            }
            MessageBox.Show(toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox3.Items.Add("Merhabalar"+i);
                i++;
            } 
            while (i<= 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac==30)
            {
               // timer1.Stop();
                this.BackColor = Color.Red;
            }
            if (sayac==40)
            {
                this.BackColor = Color.Yellow;
            }

            if (sayac == 60)
            {
                this.BackColor = Color.Green;
                sayac = 0;
            }

        
        }
        int saat = 0, saniye=0, dakika=0;

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value==100)
            {
                MessageBox.Show("Islem tamam");
                button4.Enabled=false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
               
                progressBar1.Value -= 10;
            
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                button5.Enabled = false;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                button5.Enabled = false;

            }
            else
            {
                button5.Enabled = true;
            }
            saniye++;
            label8.Text = saniye.ToString();
            if (saniye==60)
            {
                dakika++;
                saniye = 0;
                label7.Text = dakika.ToString();
            }
            if (dakika == 60)
            {
                saat++;
                dakika = 0;
                label6.Text = saat.ToString();
            }
        }
    }
}
