using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //çoklu dizi oluşturma [,] ve {{}} kullanılarak yapılır.
            //2 boyutlu
            int[,] dizi2 = { { -2, 3 }, { 4, 6 }, { 1, 9 } };
            Console.WriteLine(dizi2[0, 0]);

            //3 boyutlu [,,] ve {{{}}} kullanılarak yapılır.
            int[,,] dizi3 = { { { 1, 2 }, { 5, 6 }, { 7, 7 } }, { { 7, 4 }, { 0, 9 }, { -5, -7 } } };
            Console.WriteLine(dizi3[1,1,1]);

            //for ile dizinin içini doldurma (2 boyutlu)
            int[,] doldurulacakdizi = new int [5,5];
            for (int i = 0; i < doldurulacakdizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j < doldurulacakdizi.GetUpperBound(1); j++)
                {
                    doldurulacakdizi[i, j] = i;        
                }
            }

            for (int i = 0; i < doldurulacakdizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j < doldurulacakdizi.GetUpperBound(1); j++)
                {
                    Console.Write(doldurulacakdizi[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");

            //for ile dizinin içini doldurma (3 boyutlu)
            int[,,] doldurulacakdizi3 = new int[5, 5,5];
            for (int i = 0; i < doldurulacakdizi3.GetUpperBound(0); i++)
            {
                for (int j = 0; j < doldurulacakdizi3.GetUpperBound(1); j++)
                {
                    for (int z = 0; z < doldurulacakdizi3.GetUpperBound(2); z++)
                    {
                        doldurulacakdizi3[i, j,z] = i;
                    }
                }
            }

            for (int i = 0; i < doldurulacakdizi3.GetUpperBound(0); i++)
            {
                for (int j = 0; j < doldurulacakdizi3.GetUpperBound(1); j++)
                {
                    for (int z = 0; z < doldurulacakdizi3.GetUpperBound(2); z++)
                    {
                        Console.Write(doldurulacakdizi3[i, j, z]+" "); 
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
