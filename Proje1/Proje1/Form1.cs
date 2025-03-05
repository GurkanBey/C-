using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1 // Projenin ismi burada
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Butona tiklandiginda ne olacagi hakkinda fonksiyonlar buraya yazilir
        
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Gurkan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text;
            label8.Text = textBox3.Text;
            label7.Text = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Pc Engineer";
            label11.Text = textBox1.Text;
        }
    }
}
