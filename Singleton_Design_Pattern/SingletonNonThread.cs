using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public sealed class SingletonNonThread
    {
        private static int counter = 0;

        public static SingletonNonThread Instance = null;

        public static SingletonNonThread GetInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new SingletonNonThread();
            }
            //Return the Singleton Instance
            return Instance;
        }

        private SingletonNonThread() 
        {
            counter++;
            Console.WriteLine($"Counter value is : " + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
