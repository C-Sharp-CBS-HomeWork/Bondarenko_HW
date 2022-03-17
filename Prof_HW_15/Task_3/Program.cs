using System;
using System.Numerics;


namespace Task_3
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
            BigInteger rez = await Task<BigInteger>.Run(() =>
            {
                BigInteger rez = 1;
                for (int i = 2; i <= numb; i++)
                {
                    rez *= i;
                }
                return rez;
            }).ConfigureAwait(false);
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} | Name: {Thread.CurrentThread.Name} | isPool: {Thread.CurrentThread.IsThreadPoolThread}");
            return rez;
        }
    }
}
