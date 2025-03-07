using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14
{
    class Araba : ArabaDetay // Sinif yapisi olusturulur // kalitim konusu
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;// bu alanlara suan erisilmiyor
        private string marka;// bu alanlara suan direkt erisilmiyor

        //bunun icin su yapilir

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }


    }

}
