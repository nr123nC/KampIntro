using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2; //Bu noktada sayi2 değeri sayi1 e 1 kez aktarıldı ve ikisi arasındaki ilişki bitti
            sayi2 = 65;
            //sayi1 ??   
            //Bu durumda sayi1 değeri 30 a eşit olacaktır.


            int[] sayilar1 = new int[] { 10 ,20,30 };
            int[] sayilar2 = new int[] { 100 ,200,300 };
            sayilar1 = sayilar2; //Bu noktada sayilar1 ve sayilar2 değerinin adresleri aynı yapıldı. Adresler ortaklaştırıldığı taktirde bu noktada sayilar2 adresinde bir değişiklik yapıldığında artık
                                 //aynı değişiklik sayilar1 in adresi de aynı olduğu içinsayilar1 için de geçerli olacaktır.
            sayilar2[0] = 999;
            //sayilar1[0] ???

        // Bu durumda sayilar1[0] değeri 999 a eşit olacaktır.


        //Aynı mantıkta yapılan iki işlemin sonucunun farklı olmasının  sebebi. Verilerin bellekte tutuldukları alan ile alakalı bir durumdur.
        //int vb veri tipleri stack altında tutulurken, array vb veri tipleri stack altında tanımlanmış ve heap ten değerleri çeken numaralar altında tutulur. Bu nedenle iki sonuç farklı çıkmıştır.

            //Eğer bu bölüm kodu yazan kişi tarafından aşılırsa STACK OVERFLOW hatası ile karşılaşabilir.
        }
    }
}
