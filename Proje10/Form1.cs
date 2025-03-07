using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje10
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.BackColor = Color.LightGreen;
                MessageBox.Show(" Un ve Yumurta karistirildi");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                progressBar2.Value += 5;
                if (progressBar2.Value == 100)
                {
                    timer2.Stop();
                    label2.BackColor = Color.LightBlue;
                    MessageBox.Show("Cirpma islemi yapildi");

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                progressBar3.Value += 20;
                if (progressBar3.Value == 100)
                {
                    timer3.Stop();
                    label3.BackColor = Color.LightCyan;
                    MessageBox.Show("Malzemeler karistirildi");
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100)
            {
                progressBar4.Value += 5;
                if (progressBar4.Value == 100)
                {
                    timer4.Stop();
                    label4.BackColor = Color.LightPink;
                    MessageBox.Show("Pastaniz pisti");
                }
            }
        }
    }
}
