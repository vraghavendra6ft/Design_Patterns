using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class SingletonUsingEager
    {
        private static int counter = 0;

        private static readonly SingletonUsingEager instance = new SingletonUsingEager();

        private SingletonUsingEager()
        {
            counter++;
            Console.WriteLine($"Counter value From Lazy Implentation : {counter}");
        }

        public static SingletonUsingEager GetInstance()
        {
            return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
