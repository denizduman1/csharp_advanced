using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Person
    {
        public string school;
        public int schoolEnum;
        public Schools schools;
    }
    enum Schools
    {
        //başlangıç değerleri 0-1-2 biz de atayabiliriz.
        PrimarySchool, HighSchool, University
    }


    class Program
    {
        static void Main(string[] args)
        {
            //enum
            //stringlerle işlem yapmak zorlaştıracak.
            //boşluk bırakmama gibi hatalar yanlış sonuç almamıza sebep olur.
            //sayılara karşılık değer çıkartır.

            Person person = new Person();
            person.school = "Primary School";
            person.schoolEnum = 0;
            person.schools = Schools.PrimarySchool;
            Console.WriteLine(Schools.PrimarySchool);

            if (person.schools.Equals(Schools.PrimarySchool))
            {
                Console.WriteLine("Eşit oldu");
            }

            //Bu şekilde yapınca da anlamsız oluyor.
            if (person.schoolEnum.Equals(0))
            {
                Console.WriteLine("Eşit");
            }
            if (person.school.Equals("Primary School"))
            {
                Console.WriteLine("Eşit oldu");
            }
            Console.ReadLine();
        }
    }
}
