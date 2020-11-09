using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        delegate void Test();
        static event Test x;
        //{
        //    //add
        //    //{
        //    //    Console.WriteLine("add");
        //    //}
        //    //remove
        //    //{
        //    //    Console.WriteLine("remove");
        //    //}
        //}
        static event EventHandler myEvent;
        static void Main(string[] args)
        {
            //events şart sağlandığında gerçekleşen olaylardır.Genelde form arayüzlerinde kullanılır.
            //önce delegate lazım
            x += Deneme;
            x += Program_x;
            x += myeventvoid;
            x -= Program_x;
            x();
            Console.ReadLine();
        }

        private static void myeventvoid()
        {
            Console.WriteLine("my event void");
        }

        private static void Program_x()
        {
            Console.WriteLine("Programx");
        }

        static void Deneme()
        {
            Console.WriteLine("Deneme");
        }
    }
}
