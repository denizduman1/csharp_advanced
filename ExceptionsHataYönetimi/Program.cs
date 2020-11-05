using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHataYönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw hataların fırlatılmasında rol alır.
            //Exception ex = new Exception("Bu bir hata.",new Exception("inner exception kısmı yazılır."));
            //ex.Source = "Program"; //hatanın kaynağının nerde olduğunu belirtir.
            ////  throw ex;
            //MyExcepiton myExc = new MyExcepiton("hata","inner hata");
            //throw myExc;

            //try:dene
            //catch:hata yakalanırsa çalışacaklar
            //finally:en son her türlü çalışacak
            //try
            //{
            //    int x = 5;
            //    int y = 0;
            //    x = x / y;
            //}
            ////catchlerden biri çalışırsa diğeri çalışmaz.
            //catch(DivideByZeroException zero)
            //{
            //    Console.WriteLine(zero.Source); //namespace 
            //    Console.WriteLine(zero.StackTrace); //kodun yolu
            //    Console.WriteLine(zero.Message);
            //    Console.WriteLine("Sıfıra bölme yapılamaz.");
            //}
            //catch
            //{
            //    Console.WriteLine("Bilinmeyen bir hata");
            //}
            //finally
            //{
            //    Console.WriteLine("Son çalışacak olan");
            //}

            try
            {
                hataFirlat();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        static void hataFirlat()
        {
            Exception exc = new Exception("hataFirlat");
            try
            {
                throw exc;
            }
            catch
            {
                throw new Exception("catch yakaldı", new Exception("alt hata"));
            }
        }
    }
   //class MyExcepiton : Exception
   //{
   //     public MyExcepiton(string text) : base(text) { }
   //     public MyExcepiton(string text, string text2) : base(text, new Exception(text2)) { }
   //}
}
