using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14_Console1
{
    class kisiler
    {
        public void kisilistesi(string ad)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+ad);
            }
            
        }
        public void info(string ad1, string soyad1, string meslek1, int yas1)
        {
            Console.WriteLine(ad1); 
            Console.WriteLine(soyad1);
            Console.WriteLine(meslek1);
            Console.WriteLine(yas1);
        }
    }
}
