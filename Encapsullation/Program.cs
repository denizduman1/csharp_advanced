using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullation
{
    class Person
    {
        public string name;
        private string _surname;
        public string Surname
        {
            //get veri döndürü set ise değişkene gelen value'yi atar.
            get
            {
                //Geri döndürülen yer.
                return _surname;
            }
            set
            {
                //Veri üzerinde set(ayarlama) işlemleri
                //gelen veri => value olur
                //private değişkene atarız.
                _surname = value;
            }
        }
        public void Goster()
        {
            Console.WriteLine(_surname);
        }
    }

    class Program
    {
        static void Main()
        {
            //Encapsullation
            //Verilere erişimin kontrollü bir şekilde olmasını sağlayan yapı.
            Person p1 = new Person();
           //name bir fielddir.
            p1.name = "asdasda";
            //boş döner
            p1.Goster();
            //surname bir propertydir.
            p1.Surname = "Duman";
            Console.WriteLine(p1.Surname);
            p1.Goster();
            Console.ReadLine();
        }
    }
}
