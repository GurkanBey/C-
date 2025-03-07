using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Merhaba Dunya");
            string kelime;
            kelime = "Merbalar";
            Console.WriteLine(kelime);
           // Console.Read();

            Mesaj msj = new Mesaj();
            msj.metin();
            //Console.Read();

            kisiler liste1 = new kisiler();
            liste1.kisilistesi(".Kisiler");
            
            
            Console.WriteLine("====================");
            string kisiler1;
            Console.WriteLine("Isim giriniz");
            kisiler1 = Console.ReadLine();
            liste1.kisilistesi(kisiler1);*/

            //Biz burada oncelikle bir sinif olusturduk ve siniftan bir nesne turettik daha sonra o sinif icersinde bir metot tanimadik
            //daha sonra klavyeden deger alarak o degerleri olusturmus oldugumuz metota dondurduk ve ekrana yazdirdik

            /* 
            kisiler liste2 = new kisiler();
            string adiniz, soyadiniz, mesleginiz;
            int yasiniz;
            Console.WriteLine("Isim giriniz");
            adiniz = Console.ReadLine();
            Console.WriteLine("soyIsim giriniz");
            soyadiniz = Console.ReadLine();
            Console.WriteLine("Meslek giriniz");
            mesleginiz = Console.ReadLine();
            Console.WriteLine("Yas giriniz");
            yasiniz = Convert.ToInt32(Console.ReadLine());// Burada direkt int deger alinamadigi icin degisken donusumu yapilir

            liste2.info(adiniz, soyadiniz, mesleginiz, yasiniz);
            */


            /* 
            islem islem1 = new islem();
            Console.WriteLine("1. sayi giriniz");
            int s1;
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayi giriniz");
            int s2;
            s2 = Convert.ToInt32(Console.ReadLine());
            islem1.topla(s1, s2);
            */
            //ogrenci ogr1 = new ogrenci();
            //Console.Read();

            
            string adiniz, soyadiniz, mesleginiz;
            int yasiniz;
            Console.WriteLine("Isim giriniz");
            adiniz = Console.ReadLine();
            Console.WriteLine("soyIsim giriniz");
            soyadiniz = Console.ReadLine();
            Console.WriteLine("Meslek giriniz");
            mesleginiz = Console.ReadLine();
            Console.WriteLine("Yas giriniz");
            yasiniz = Convert.ToInt32(Console.ReadLine());// Burada direkt int deger alinamadigi icin degisken donusumu yapilir
            ogrenci1 ogr1 = new ogrenci1(adiniz,soyadiniz,mesleginiz,yasiniz);
            Console.Read();

        }
    }
}
