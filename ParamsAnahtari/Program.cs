using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsAnahtari
{
   
    class Program
    {
        static int topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static int toplacoklu(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            //params
            //Kullanım şekli: params key wordü yanina veri tipi ve [] diziAdi, paramsin sağına başka değişken yazamayız.
            //Neden kullanırız:Ne kadar sayıda parametre girebileceğimizi kestiremediğimiz durumlarda.
            //params int[] sayilar

            Console.WriteLine(topla(1,2,3));
            Console.WriteLine(toplacoklu(1,2,3,4,5,6,7,8,9,10));
            
            
            Console.ReadLine();
        }
    }
}
