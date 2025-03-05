using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:"+comboBox1.Text+"-"+comboBox2.Text+" - "+"Tarih:"+dateTimePicker1.Text+" - "+"Saat:"+maskedTextBox1.Text );
            listBox1.Items.Add("Yolcu Ad Soyadi:"+textBox1.Text);
            listBox1.Items.Add("Yolcu Tc:" + maskedTextBox2.Text);
            listBox1.Items.Add("Yolcu Telefon:" + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydi Tamamlandi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
