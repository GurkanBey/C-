using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14_Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            kimlik kimlik1 = new kimlik();
            int yasiniz;
            kimlik1.AD = "Gurkan";
            kimlik1.SOYAD = "Parlak";
            Console.WriteLine("Yas giriniz");
            yasiniz = Convert.ToInt32(Console.ReadLine());
            kimlik1.YAS = yasiniz;



            Console.WriteLine(kimlik1.AD);
            Console.WriteLine(kimlik1.SOYAD);
            Console.WriteLine(kimlik1.MESLEK);
            Console.WriteLine(kimlik1.YAS);
            Console.WriteLine(kimlik1.CINSIYET);
            Console.ReadLine();
        }
    }
}
