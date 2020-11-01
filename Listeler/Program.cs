using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listeler dizilere göre daha kullanışlıdır bir sınırı yoktur.
            List<int> numbers = new List<int>{ 2,5,4,4,9,7};
            numbers.Add(-5);
            numbers.Add(-9);
            
            // remove komutu içinde 4 olan elemanı siler.
            // birden fazla ise ilkini siler.
            numbers.Remove(4);

            //remove at komutu ise indexe göre silme işlemi yapar. 
            numbers.RemoveAt(2);

            //insert komutu indexe göre eklenecek elemanı yerleştirir.
            numbers.Insert(2, -15);

            //elemanın listenin kaçıncı elemanda bulunduğunu gösterir.
            Console.WriteLine(numbers.BinarySearch(-15));

            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();

            //Listedeki elemanları tersine çevirir.
            numbers.Reverse();

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
