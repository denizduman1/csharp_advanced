using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerveReferansTipler
{
    class Program
    {
        //deger tipler stackte tutulurken referans tiplerin değerleri heap'te tutulur.

        static void Main(string[] args)
        {
            //stackte tutulduğu için değişmez
            int a = 5;
            Console.WriteLine("a = " + a);
            degistir(a);
            Console.WriteLine("a = "+a);

            //diziler referans tipli oldukları için değerleri heapte tutulur ve değiştirilebilir.
            int []dizi = { 0, 1 };
            Console.WriteLine("dizinin elemanları sırasıyla = "+dizi[0]+" "+dizi[1]);
            dizidegistir(dizi);
            Console.WriteLine("dizinin elemanları sırasıyla = "+ dizi[0] + " " + dizi[1]);

            Console.ReadLine();
        }
        static void degistir(int x)
        {
            x = 0;
        }
        static void dizidegistir(int []dizi)
        {
            dizi[0] = 5;
            dizi[1] = 10;
        }
    }
}
