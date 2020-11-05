using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnahtarKelimesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //base anahtar kelimesi
            //alt sınıftayken ata sınıftaki elemanlara ulaşmamıza yarıyor.

            A nesne = new A();
            nesne.Yaz();
            Console.ReadLine();
        }
    }
    class A:B
    {
        public new void Yaz() 
        {
            base.Yaz();
            Console.WriteLine("A:B");
        }
    }
    class B
    {
        public void Yaz() => Console.WriteLine("B");
    }
}
