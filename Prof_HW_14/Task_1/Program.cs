using System;
using System.Threading;

namespace Task_1
{
    public class Program
    {
        private static object _lock = new object();
        private static int counter = 0;

        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Task task = IncrementAsync();
                task.Wait();
            }
        }

        public static async Task IncrementAsync()
        {
            await Task.Run(() => Increment());
        }

        public static void Increment()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Thread: [{Thread.CurrentThread.ManagedThreadId}] - Counter: {++counter}");
        }
    }
}
