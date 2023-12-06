using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Classlar
{
    public class Toplama : Sayilar
    {
        private int sonuc;
        public int Sonuc { get { return sonuc; } set { sonuc = value; } }

        public int topla()
        {
            sonuc = Sayi1 + Sayi2 + Sayi3;
            return sonuc;
        }
    }
}
