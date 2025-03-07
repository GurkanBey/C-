using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje13
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //void geriye deger dondurmeyen fonksiyonlar icin kullanilir
        int toplam (int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int carpim (int a1,int a2,int a3)
        {
            int carp = a1 * a2 * a3;
            return carp;
        }

        int kup_hesapla(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        int toplayici (int say1,int say2)
        {
            int sonuc1 = say1 + say2;
            return  sonuc1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(4, 6).ToString();
            label2.Text = toplam(25, 12).ToString();
            label3.Text = toplam(12, 79).ToString();
            label4.Text = carpim(12, 2, 3).ToString();
            label5.Text = carpim(5, 6, 7).ToString();
            label6.Text = carpim(2, 3, 4).ToString();
            int s = Convert.ToInt32(textBox1.Text);
            label7.Text = kup_hesapla(s).ToString();

            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            label8.Text = toplayici(x, y).ToString();

        }
    }
}
