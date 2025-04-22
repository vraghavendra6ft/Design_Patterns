using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class SingletonUsingLazy
    {
        private static int counter = 0;

        private static readonly Lazy<SingletonUsingLazy> instance = new Lazy<SingletonUsingLazy>(() => new SingletonUsingLazy());   

        private SingletonUsingLazy() 
        {
            counter++;
            Console.WriteLine($"Counter value From Lazy Implentation : {counter}");
        }    

        public static SingletonUsingLazy GetInstance()
        {
            return instance.Value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
