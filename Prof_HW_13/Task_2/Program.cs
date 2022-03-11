using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            Task[] tasks = new Task[2];
            tasks[0] = Task.Run(SomeMethod);
            tasks[1] = Task.Run(SomeMethod2);

            Work("Main");

            Task.WaitAll(tasks[0], tasks[1]);
        }

        public static void SomeMethod() => Work("SomeMethod");
        public static void SomeMethod2() => Work("SomeMetho2");

        private static void Work(string MethodName)
        {
            int stop = 50;
            if (MethodName == "Main")
                stop = 20;
                
            for (int i = 0; i < stop; i++)
            {
                Console.WriteLine($"{MethodName} : Counter [{i}] : {Task.CurrentId} : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            }
        }
    }
}
