using Metotlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        //naming convention pythondaki fonksiyon hesabı
        public void Ekle(Urun urun) //ne ekleneceğini belirtmek için parametre verdik
        {
            Console.WriteLine("Tebrikler Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi: " + urunAdi);
        }
    }
}
