using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionveYıkıcıMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Garbage collector 
            //Heap'e bakar refaransı olmayan değerleri siler.
            A nesne = new A();
            new A();
            GC.Collect(); //default olarak kendisi siler fakat biz görmek istiyorsak çağırıp bakabiliriz.
            B nesneb = new B();

            Console.ReadLine();
        }
    }
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor");
        }
        ~A()
        {
            Console.WriteLine("Destructor");
        }
    }
    class B
    {
        public B()
        {
            Console.WriteLine("Constructor");
        }
        ~B()
        {
            //nesne silinmeden önce çalışır ve ardından nesne silinir.
            Console.WriteLine("Destructor");
        }       
    }
}
