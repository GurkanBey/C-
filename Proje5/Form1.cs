using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sut, yumurta, su, yag, cay, pirinc, bulgur, seker, toplam;
            sut = Convert.ToInt32(maskedTextBox1.Text);
            yumurta = Convert.ToInt32(maskedTextBox2.Text);
            su = Convert.ToInt32(maskedTextBox3.Text);
            yag = Convert.ToInt32(maskedTextBox4.Text);
            cay = Convert.ToInt32(maskedTextBox5.Text);
            pirinc = Convert.ToInt32(maskedTextBox6.Text);
            bulgur = Convert.ToInt32(maskedTextBox7.Text);
            seker = Convert.ToInt32(maskedTextBox8.Text);

            toplam = (sut*22) + (yumurta*30) + (su*27) + (yag*55) + (cay*80) + (pirinc*60) + (bulgur*25) + (seker*48);
            label18.Text = toplam.ToString()+"TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label18.Text = "--";
        }
    }
}
