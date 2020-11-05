using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefveOutAnahtarKelimeleri
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            Console.WriteLine("X = " + x);
            degistir(ref x);
            Console.WriteLine("X = " + x);

            int y;
            degistir2(out y);
            Console.WriteLine("Y = " + y);

            Console.ReadLine();
        }
        static void degistir(ref int sayi)
        {
            sayi = 10; 
        }
        static void degistir2(out int sayi)
        {
            sayi = 30;
        }
    }
}