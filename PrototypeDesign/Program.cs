using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //prototype deseni ile new lenen bir class tan sonra başka nesne oluştururken new operatorunden kurtulmak
            Computer monster = new Computer();
            Computer msi = (Computer)monster.Clone();
            monster.UrunAdi = "Monster";
            monster.UrunFiyati = 4500m;
            monster.Islemci = "Intel i9";
            msi.UrunAdi = "Msi";
            msi.UrunFiyati = 3500m;
            msi.Islemci = "Intel i5";
            Console.WriteLine(monster.UrunAdi + monster.UrunFiyati + monster.Islemci + "        " + msi.UrunAdi + msi.UrunFiyati + msi.Islemci);
        }
    }
     
    abstract class Electronic
    {
        public abstract Electronic Clone();
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
    }

    class Computer : Electronic
    {
        public override Electronic Clone()
        {
            return (Computer)MemberwiseClone();
        }
        public string Islemci { get; set; }
    }

    class Television : Electronic
    {
        public override Electronic Clone()
        {
            return (Television)MemberwiseClone();
        }
        public string Hertz { get; set; }
    }
}
