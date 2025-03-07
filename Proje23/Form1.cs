using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje23
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString(); // Mutlak degerini alir
            //label2.Text = Math.Ceiling(sayi).ToString(); // yuvarlama yukari 
            //label2.Text = Math.Floor(sayi).ToString(); asagi yuvarlama
            //label2.Text = Math.Pow(sayi, 3).ToString();// ussunu alma islemi
            label2.Text = Math.Sqrt(sayi).ToString(); // kok alma islemi


            
        }
    }
}
