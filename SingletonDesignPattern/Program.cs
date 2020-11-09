using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton design patterni 
            //Aynı işlemin birden fazla işlemciden çalıştırılıp her seferinde newlenmesi ram için pahalı bir işlemdir.
            //Bu yüzden bir classtan tek bir örnek çıkarırız.
            //Kullanıcıların bağlantı işleri gibi kendilerine özel olmayan işlevlerde bu patterni kullanırız
            //Her kullanıcının kendisine ait yaptığı işlemlerde kullanmaya çalışırsak veriler karışır.

            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();

            var dataAccesObject = DataAccess.CreateInstance();
            dataAccesObject.Display();

            var exampleObject = Example.CreateSingleton();
            exampleObject.Display();
           
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static object _lockObject = new object(); //aynı anda çalışabilecek threadler için kilit önlemi

        private CustomerManager() { } //Dış erişimi private ile engelledik.
        public static CustomerManager CreateAsSingleton() 
        {
            if (_customerManager==null)
            {
                lock (_lockObject)
                {
                    if (_customerManager == null) //fieldimiz daha önce çağrılmış mı kontrol ediyoruz.
                    {
                        _customerManager = new CustomerManager();//çağrılmamış ise new ataması yapıyoruz.
                    }
                }
                
            }
            return _customerManager;
        }
        public void Save()
        {
            Console.WriteLine("Customer Saved!");
        }
    }

    class DataAccess
    {
        private static DataAccess _dataAccess;
        private static object _objectLock = new object();
        private DataAccess()
        {
        }
        public static DataAccess CreateInstance()
        {
            if (_dataAccess==null)
            {
                lock (_objectLock)
                {
                    if (_dataAccess == null)
                    {
                        _dataAccess = new DataAccess();

                    }
                }      
            }
            return _dataAccess;
        }
        public void Display()
        {
            Console.WriteLine("DataAcccess!");
        }
    }

    class Example
    {
        private static Example _example;
        private static object lockObject = new object();
        private Example(){}
        public static Example CreateSingleton()
        {
            if (_example==null)
            {
                lock (lockObject)
                {
                    if (_example==null)
                    {
                        _example = new Example();
                    }
                }               
            }
            return _example;
        }
        public void Display() {Console.WriteLine("Created!");}
    }
}