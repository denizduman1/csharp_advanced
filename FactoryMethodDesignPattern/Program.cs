using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method Design
            Factory factory = new Factory();
            Oyun oyun_nesnesi = factory.FactoryMethod(Oyunlar.PS5);
            oyun_nesnesi.display();
            Console.ReadLine();
        }
    }

    class Factory
    {
        private static Oyun _Object;
        public Oyun FactoryMethod(Oyunlar oyunlar)
        {
            switch (oyunlar)
            {
                case Oyunlar.XBOX:
                    _Object = new XBOX();
                    break;
                case Oyunlar.PC:
                    _Object = new PC();
                    break;
                case Oyunlar.PS5:
                    _Object = new PS5();
                    break;
                default:
                    break;
            }
            return _Object;
        }
    }

    enum Oyunlar
    {
       XBOX,PC,PS5
    }
    interface Oyun
    {
        void display();
    }
    class XBOX : Oyun
    {
        public void display()
        {
            Console.WriteLine("Bu bir XBOX oyunudur.");
        }
    }
    class PC : Oyun
    {
        public void display()
        {
            Console.WriteLine("Bu bir PC oyunudur.");
        }
    }

    class PS5 : Oyun
    {
        public void display()
        {
            Console.WriteLine("Bu bir playstation 5 oyunudur.");
        }
    }
}
