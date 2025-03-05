using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text); //Textbox iciresine girilen ogeleri combobox`a ekleme islevi
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nurse");
            listBox1.Items.Add("Fireman");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);//Textbox iciresine girilen ogeleri listbox`a ekleme islevi
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + " \n " + maskedTextBox2.Text + " \n " + maskedTextBox3.Text + " \n " + maskedTextBox4.Text + " \n ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = dateTimePicker1.Text;
        }
    }
}
