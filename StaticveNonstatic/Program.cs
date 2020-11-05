using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticveNonstatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.yazdir("Deniz");
            Console.WriteLine();
            yazdirS("DenizS");

            MyClass nesne1 = new MyClass();
            MyClass nesne2 = new MyClass();
            nesne1.counter = 1;
            nesne2.counter = 2;
            MyClass.counter_S = 3;

            MyClassS.Yazdir();
            Console.ReadLine();
        }
        void yazdir(string text)
        {
            Console.WriteLine(text);
        }
        static void yazdirS(string text) {
            Console.WriteLine(text);
        }
    }
    class MyClass 
    {
        public int counter { get; set; }
        static public int counter_S { get; set; }
    }

    static class MyClassS
    {
        //içineki method'da static olmalı.
        public static void Yazdir()
        {
            Console.WriteLine("YazdirS");
        }
        static MyClassS()
        {
            Console.WriteLine("Statik constructor çalıştı.");
        }
    }
}