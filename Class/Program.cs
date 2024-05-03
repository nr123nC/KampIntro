using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "nergis";
            int yasi = 25;
            Product product1 = new Product(); //class kullanılırken static void in içerisinde yer almalıdır.

            product1.ProductName = "Etek";
            product1.BrandName = "Stradivarius";
            product1.Size = 36;

            Product product2 = new Product();

            product2.ProductName = "Gömlek";
            product2.BrandName = "Pull & Bear";
            product2.Size =34;

            Product product3 = new Product();

            product3.ProductName = "Ayakkabı";
            product3.BrandName = "Nike";
            product3.Size = 38;

            Product [] products=new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName+":"+product.BrandName+":"+product.Size); 
            }

            Console.WriteLine("Foreach ile yazdırma işlemi tamamlandı****************************************************************************");

            for (int i = 0; i < products.Length; i++) 
            {
                Console.WriteLine(products[i].ProductName + ":" + products[i].BrandName + ":" + products[i].Size);
            }

            Console.WriteLine("For ile yazdırma işlemi tamamlandı****************************************************************************");
            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine(products[j].ProductName + ":" + products[j].BrandName + ":" + products[j].Size);
                j++;

            }

            Console.WriteLine("While ile yazdırma işlemi tamamlandı****************************************************************************");    

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Nergis";
            kurs1.izlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ali";
            kurs2.izlenmeOrani = 50;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Ahmet";
            kurs3.izlenmeOrani = 20;

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)  //var dendiğinde hangi veri tipinde ise o veri tipi çalışır
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }

            Console.WriteLine("--------------------Metodlar----------------------");

            BasketManager basketManager= new BasketManager();
        }
    }

    class Kurs  //kurs artık bizim için string int vb gibi bir değişken türü ve Kurs altında bir şey tanımlamak istediğimizde string ve int tanımlayabiliriz.
    {
        public string KursAdi { get; set; } //bu satırı hızlı bir şekilde yazmak için prop yazılı tab tab basılır.
        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }

  
    class Product
    {
        public string ProductName { get; set; }
        public string BrandName { get; set; }

        public int Size { get; set;}
    }


    
}
