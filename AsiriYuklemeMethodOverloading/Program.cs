using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiriYuklemeMethodOverloading
{
    class Program
    {
        static int topla(int a,int b)
        {
            return a + b;
        }
        static int topla(int a,int b,int c)
        {
            return a + b + c;
        }
        static double topla(double a,double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Overloading
            //aynı method adını farklı parametreler ile farklı işlemler yaptırabiliriz.
            Console.WriteLine(topla(1,2));
            Console.WriteLine(topla(1, 5, 9));
            Console.WriteLine(topla(1.9,2.9));
            Console.ReadLine();
        }
    }
}