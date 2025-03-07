using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje12
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Honeydew;
            textBox4.BackColor = Color.Indigo;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
        void yazdir()
        {
            textBox1.Text = "Gurkan";
            textBox2.Text = "Parlak";
            textBox3.Text = "Bilgisayar";
            textBox4.Text = "Muhendisi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazdir();
        }
    }
}
