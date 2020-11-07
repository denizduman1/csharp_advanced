using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method Design
            Business b1 = new Business();
            b1.Save();
        }
    }
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DdLogger();
        }
    }
    public interface ILoggerFactory
    {

    }
    public interface ILogger
    {
        void Log();
    }
    public class DdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with DD");
        }
    }
    public class Business
    {
        public void Save()
        {
            Console.WriteLine("Saved!");
            ILogger logger = new LoggerFactory().CreateLogger();
            logger.Log();
        }
    }
}
