using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurucuMethodlar
{
    class Kisi
    {
        private string _ad;
        private string _soyad;
        private string _tc;
        public Kisi(string ad,string soyad,string tc)
        {
            _ad = ad;
            _soyad = soyad;
            _tc = tc;
        }
        public void VerileriGoster()
        {
            Console.WriteLine(_ad+" "+_soyad+" "+_tc);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //constructor
            //sınıf oluşturulurken çalışan methoddur.
            //ilk atamaları yapmada işe yarar.

            Kisi kisi = new Kisi("Deniz","Duman","12345678910");
            kisi.VerileriGoster();
            Console.ReadLine();
        }
    }
}
