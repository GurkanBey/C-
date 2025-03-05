using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Degisken tanımları
            string metin,metin1;
            metin1 = "Good Morning";
            metin = "Merhabalar";
            
            label1.Text = metin;
            label2.Text = metin1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp1;
            temp1 = textBox1.Text;
            label5.Text = temp1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = 23;
            label6.Text = sayi1.ToString();//Bazi tool kullanimlari string tabanli oldugu icin string degiskenlere donusturulmelidir.
            int sayi2,sayi3,toplam;
            sayi2 = 3;
            sayi3 = 4;
            toplam = sayi2 + sayi3;
            label7.Text = toplam.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int alan, cevre,kenar ;
            kenar = Convert.ToInt16(textBox2.Text);//Kenar degiskeni textbox2`den gelen degeri Convert fonksiyonu ile string degerden int degere cevirir
            alan = kenar * kenar;
            cevre = kenar * 4;
            label11.Text = "Cevre:"+cevre; //label11.Text = cevre.ToString(); seklinde de kullanabilirsin 
            label12.Text = "Alan:"+alan;   //label12.Text = alan.ToString(); seklinde de kullanabilirsin 





        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            double  topla, carp, fark;
            double bol, num1, num2;
            num1 = Convert.ToDouble(textBox3.Text);
            num2 = Convert.ToDouble(textBox4.Text);
            topla = num1 + num2;
            carp = num1 * num2;
            fark = num1 - num2;
            bol = num1 / num2;
            //Messagebox da kullanabilirsin
            label13.Text = "Toplan:" + topla;
            label14.Text = "Carpim:" + carp;
            label15.Text = "Fark:" + fark;
            label16.Text = "Bolum:" +bol.ToString("0.00");   //label16.Text = "Bolum:" + bol;
            //Ayrica kodda . (nokta) kullanilir arayuzde ,(virgul) kullanilir


            //Integer degerler ile cozum
            /*
            int topla, carp, fark;
            int bol, num1, num2;
            num1 = Convert.ToInt32(textBox3.Text);
            num2 = Convert.ToInt32(textBox4.Text);
            topla = num1 + num2;
            carp = num1 * num2;
            fark = num1 - num2;
            bol = num1 / num2;
            //Messagebox da kullanabilirsin
            label13.Text = "Toplan:" + topla;
            label14.Text = "Carpim:" + carp;
            label15.Text = "Fark:" + fark;
            label16.Text = "Bolum:" + bol; 
           */

        }
    }
}
