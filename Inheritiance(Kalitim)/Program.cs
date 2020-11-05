using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritiance_Kalitim_
{
     
    class ProductInfos
    {
        public string productName { get; set; }
        public string price { get; set; }
        public int quantity { get; set; }
        public ProductInfos()
        {
            Console.WriteLine("Ata sınıf");
        }
    }

    class Computer:ProductInfos
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public Computer()
        {
            Console.WriteLine("Alt sınıf");
        }
    }       

    class Program
    {   
        static void Main(string[] args)
        {
            //Inheritiance(Kalıtım): benzer görevleri olan alt sınıflara ata sınıf oluşturulduktan sonra yapılan işlemdir.            
            //kalıtım alan sınıfa kalıtım aldığı sınıftaki özelliklerde eklenmiş olur.

            Computer monster = new Computer();
           

            Console.ReadLine();
        }
    }
}
