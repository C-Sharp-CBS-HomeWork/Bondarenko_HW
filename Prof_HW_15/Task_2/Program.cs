using System;
using System.Numerics;

namespace Task_2
{
    public class Program
    {
        public static async Task Main()
        {
            SynchronizationContext.SetSynchronizationContext(new MySyncContext());

            BigInteger rez = await FactorialAsync(4);
        }

        public async static Task<BigInteger> FactorialAsync(int numb)
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} | Name: {Thread.CurrentThread.Name} | isPool: {Thread.CurrentThread.IsThreadPoolThread}");
            BigInteger rezult = await Task.Run(() =>
            {
                BigInteger rez = 1;
                for (int i = 2; i <= numb; i++)
                {
                    rez *= i;
                }
                return rez;
            });
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} | Name: {Thread.CurrentThread.Name} | isPool: {Thread.CurrentThread.IsThreadPoolThread}");
            return rezult;
        }
    }
}
