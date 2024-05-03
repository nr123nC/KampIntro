using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Python","Java","C#"};



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  //dizileri tek tek dolaşır  kurs değişkeni burada tanımlanmış olur
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa sonu");
        }
    }
}
