using Metotlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id= 0;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();

            urun2.Id = 1;   
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id+":"+urun.Adi+"***************************************");
            }

            Console.WriteLine("------------------Metotlar----------------------------"); //hızlı bir şekilde console writline yazmak için cw yazarak tab tab basılır
            Console.WriteLine("Hızlı bir şekilde console writline yazdırdık");

            //encapsulation


            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun2);

            basketManager.Ekle2("Armut", "Yeşil armut", 12); //Ctrl +D ile bulunduğun satırı kopyalayabilirsin
            basketManager.Ekle2("Karpuz", "Kırmızı", 20);



        }
    }
}


//