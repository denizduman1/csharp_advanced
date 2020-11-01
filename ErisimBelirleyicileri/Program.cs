using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    class Kisi
    {
        //public : her yerden erişilebilir.
        public string Ad;

        //private : dahil olduğu kod blokları hariç geçerlidir.sınıf içinde default değer private'dır.
        private string _Ad;

        //internal : class'larda default değer aynı programda ulaşılabilir.
        internal string ad;

        //protected : dahil olduğu sınıfa ve kalıtım alan sınıflarda sınıf içinde kullanılabilir.
        protected string aD;

        public void Getir()
        {
            _Ad = "private";
            Ad = "public";
            ad = "Defaultinternal";
            aD = "Protected";
            Console.WriteLine(_Ad+Ad+ad+aD);
        }
    }

    class Hoca : Kisi
    {
        public void Getir()
        {
            //_Ad = "private"; gelmez.
            Ad = "public";
            ad = "Defaultinternal";
            aD = "Protected";
            Console.WriteLine(Ad+ ad+ aD);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyecileri..

            Kisi kisi = new Kisi();
            kisi.Getir();
           
            Hoca hoca = new Hoca();
            hoca.Getir();

            Console.ReadLine();
        }
    }
}
