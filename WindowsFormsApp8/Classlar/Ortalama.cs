using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Classlar
{
    public class Ortalama:Sayilar
    {
        private double  sonuc;
        public double  Sonuc { get { return Sonuc; }set { sonuc = value; } }

        public double OrtHesapla()
        {
            sonuc = (Sayi1 + Sayi2 + Sayi3) / 3;
            return sonuc;
        }
       
    }
}
