using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate double MyDelegate(double a,double b);
        delegate double MyDelegate2(double a, double b);
        delegate void MyDelegate3(double a, double b);
        static void Main(string[] args)
        {
            //delegateler methodlara refarans ediyor
            //delegateleri methodları daha iyi yönetmek için kullanırız.
            MyDelegate myDelegate = new MyDelegate(cevre);
            Console.WriteLine(myDelegate(4,6));
            MyDelegate2 myDelegate2 = new MyDelegate2(alan);
            Console.WriteLine(myDelegate2(4,6));
            myDelegate += alan;
            Console.WriteLine(myDelegate(4,6));
            MyDelegate3 myDelegate3 = new MyDelegate3(alan2);
            myDelegate3(5, 6);
            myDelegate3 += cevre2;
            myDelegate3(5, 8);
        }
        static double cevre(double a, double b)
        {
            return 2 * (a + b);
        }
        static double alan(double a, double b)
        {
            return a*b;
        }

        static void cevre2(double a,double b)
        {
            Console.WriteLine(2*(a+b));
        }
        static void alan2(double a,double b)
        {
            Console.WriteLine(a*b);
        }
    }

}
