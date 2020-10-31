using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLR_DynamicLanguageRuntime_
{
    class Program
    {
        static void Main(string[] args)
        {
            //DLR dynamic keyword aracığıyla farklı dillerin kodunu çalıştırabiliyoruz.
            //Örnek olarak Python kodu çalıştıralacak..

            //Python kodumuzun oluşturulma yerini çekiyoruz.
            //Python kodunu burda da yazabilirdik.
            var source = @"C:\Users\Deniz\Desktop\python\python_Examples\6.py";

            //Python motorunu çalıştırıyoruz.
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var oper = engine.Operations;

            // uygulamayı çalıştırıyoruz.
            engine.ExecuteFile(source,scope);

            //Hesap sınıfını C# daki Hesap değişkenine attık.
            //Hesap sınıfından ins adında nesne oluşturduk.
            //dynamic tür olduğu için kod da olmayan fonksiyon (aslında python da olan)
            //dinamik olarak çalışıyor.

            var Hesap = scope.GetVariable("Hesap");
            dynamic ins = oper.CreateInstance(Hesap);

            Console.WriteLine((ins.topla(15,20)));
            Console.WriteLine((ins.fark(20,15)));

            Console.ReadLine();
        }
    }
}
