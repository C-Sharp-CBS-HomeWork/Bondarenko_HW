using System;


namespace Task_1
{
    public class Program
    {
        static Semaphore semaphore = null;
        public static void Main()
        {
            semaphore = new Semaphore(3, 5, "WriteInfo");

            Thread[] threads = new Thread[40];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Work);
                threads[i].Name = $"THR{i}";
                threads[i].Start();
            }
        }

        public static void Work()
        {
            semaphore.WaitOne();

            using AccessToFile access = new AccessToFile();
            int check = new Random().Next(2);
            if (check == 1)
                access.WriteInfo(new Random().Next(10000).ToString());
            semaphore.Release();
        }
    }
}
