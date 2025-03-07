using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje14_Console2
{
    class kimlik
    {
        string ad;
        string soyad;
        string meslek;
        int yas;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public string MESLEK
        {
            get { return meslek; }
            set { meslek = value.ToUpper(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }

        }
        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public kimlik()
        {
            ad = "";
            soyad = "";
            yas = 12;
            cinsiyet = 'N';
            meslek = "-";
        }

    }
}
