using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje20
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = {"a","b","c","d","e","f" };
            string[] sembol2 = { "+", "@", "#", "$" };
            
            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 100);
            label1.Text = sembol1[s1].ToString() + sembol1[s2].ToString() + sembol2[s2].ToString()+s3.ToString()+ sembol1[s2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                MessageBox.Show("Basarili giris yapabilirsiniz");
                Form2 fr = new Form2();
                fr.Show();//formu gosterir
                this.Hide();// ikinci formu gizler
            }
            else
            {
                MessageBox.Show("Basarisiz tekrar deneyin");
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.mesaj1 = textBox2.Text;
            fr.mesaj2 = textBox3.Text;
            fr.mesaj3 = textBox4.Text;
            fr.Show();//formu gosterir
            this.Hide();// ikinci formu gizler

        }
    }
}
