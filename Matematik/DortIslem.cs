using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + fark);
        }

        //method overloading
        public void Topla(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Sonuç: " + toplam);
        }

        public void Topla(params int[] numbers)
        {
            int toplam = numbers.Sum();
            Console.WriteLine("Sonuç: " + toplam);
        }
    }
}
