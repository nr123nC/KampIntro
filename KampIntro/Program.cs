using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtkiketi = "kategori";
            
            bool sistemeGirisYapmismi= false;
            double dolarinDun=7.35;
            double dolarBugun = 7.45;

            if (dolarinDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarinDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }

            if (sistemeGirisYapmismi==true)  //iki kez tab tuşuna basarak otomatik getirdik
            {
                Console.WriteLine("Ayarlar butonu");
            }

            else
            {
                Console.WriteLine("Giris yap butonu");
            }

        }
    }
}
