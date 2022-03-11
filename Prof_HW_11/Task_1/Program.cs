using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Program
    {
        private static object _lock = new object();
        private static int counter = 0;

        public static void Main()
        {
            Thread[] threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Increment);
                threads[i].Start();
                threads[i].Join();
            }      
        }

        public static void Increment()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Thread: [{Thread.CurrentThread.ManagedThreadId}] - Counter: {++counter}");
        }
    }


}
