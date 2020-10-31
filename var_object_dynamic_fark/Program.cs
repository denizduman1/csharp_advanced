using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_object_dynamic_fark
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string y = "merhaba";

            // gelen verinin ne olduğu bilinmediği (int mi string mi) durumlarda 'var' kullanılır
            // var atanan değer türüne bürünür.
            var z = "selam";
            var w = 10;

            object a = 5; //boxing işlemi yapılmış olunuyor.
            object b = "selam";

            Console.WriteLine("object a={0} and object b={1}", a, b);
           
            //unboxing(kutudan çıkarma) işlemi yapılarak başka değişkene atanabilir. 
            //gelen verinin ne olduğu kestirilemediği durumda kutulama yapılıp 
            //daha sonra istenilen şekilde kutu açılımı yapılmasına yarıyor.
            int a1 = (int)a; 
            string b1 = (string)b;


            //object'deki gibi istenilen değişken tipini alabiliyor.
            //object'ten farklı olarak başka değişkene atanırken casting işlemi yapmaya gerek yoktur.
             
            dynamic X = 5;
            dynamic Y = "selam";
            int X1 = X; 
            string Y1 = Y;

            // dynamic object'ten farklı olarak dinamik olarak çalışabilir aşağıdaki işlemi
            // object'te çalıştırıyor olsaydık hata alacaktık.(unboxing yapmadan)
            Console.WriteLine(Y.Length);

            Console.ReadLine();
        }
    }
}
