using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje11
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = {"Ali","Gurkan","Ayse","Mustafa","Dilek" };
            //label1.Text = kisiler[2];

            int[] sayilar = {1, 2 , 3 , 4 ,5, 6, 7 };
            label1.Text = sayilar[3].ToString();
        }

        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] kisiler = {
            "Ali", "Gurkan", "Ayse", "Mustafa", "Dilek", "Mehmet", "Zeynep", "Fatma", "Yusuf", "Emre",
            "Hakan", "Deniz", "Can", "Ebru", "Seda", "Cem", "Burak", "Elif", "Mert", "Irem",
            "Serkan", "Gamze", "Okan", "Ece", "Tugba", "Baris", "Selin", "Umut", "Berk", "Buse"
        };
            
            sayac ++;
            
            if (sayac == 30 )
            {
                sayac = 0;
            }
            label2.Text = kisiler[sayac];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] kisiler = {
            "Ali", "Gurkan", "Ayse", "Mustafa", "Dilek", "Mehmet", "Zeynep", "Fatma", "Yusuf", "Emre",
            "Hakan", "Deniz", "Can", "Ebru", "Seda", "Cem", "Burak", "Elif", "Mert", "Irem",
            "Serkan", "Gamze", "Okan", "Ece", "Tugba", "Baris", "Selin", "Umut", "Berk", "Buse"
        };
            for (int i = 0; i <kisiler.Length; i++)//burada dizi uzunlugu kadar ekleme yapmali ama = kuulanilirsa 30. indexe gitmeye calisir ama diziler 0. indexden baslar
            {
                listBox1.Items.Add(kisiler[i]);
            }

            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%10 == 0 && sayilar[i]%2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] kisiler = {
            "Ali", "Gurkan", "Ayse", "Mustafa", "Dilek", "Mehmet", "Zeynep", "Fatma", "Yusuf", "Emre",
            "Hakan", "Deniz", "Can", "Ebru", "Seda", "Cem", "Burak", "Elif", "Mert", "Irem",
            "Serkan", "Gamze", "Okan", "Ece", "Tugba", "Baris", "Selin", "Umut", "Berk", "Buse"
        };
            // foreach ilk kisim degisken adidir string int char vs
            // foreach ikinci kisim degisken turu i k a b x y z  farketmez
            // in surdan al demek gibi
            // hangi dizilerden alinacak onu soyluyoruz
            foreach (string k in kisiler)
            {
                if (k == "Ali")
                {
                    MessageBox.Show("Merhaba");
                }
                listBox3.Items.Add(k);
            }

        }
        int ortalama, toplam;
        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            
            foreach (int x in sayilar)
            {
                if (x%2 == 0)
                {
                    listBox4.Items.Add(x);
                    toplam = toplam + x;

                }
                label3.Text = toplam.ToString();
                ortalama = (toplam*2) / x;
                label4.Text = ortalama.ToString();
            }
        }
    }
}
