using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //class
            //ortak iş için çalışan değişkenler ve methodları bir arada tutmak için kullanılır.
            Sinif nesne = new Sinif();
            nesne.x = 1;
            Console.WriteLine(nesne.x);
            nesne.Yazdir("Bu bir class mesajıdır.");
            
            //farklı namespacelerde proje oluştururken class'ın çalışması için default olarak internal yerine public yazmalıyız.
            Kisi firstPerson = new Kisi { 
            ad = "Deniz",
            soyad  ="Duman",
            yas = 22
            };
            firstPerson.Ozellikler();

            Console.ReadLine();
        }
    }
    class Sinif 
    {
        public int x;
        public void Yazdir(string text)
        {
            Console.WriteLine(text);
        }
    }
}
