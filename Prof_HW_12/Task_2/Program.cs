using System;
using System.Diagnostics;

namespace Task_2
{
    public class Program
    {
        private static Mutex mutex = new Mutex(false, "Procces");
        //Я не знаю, как сделать так, что бы на осонове мютекса это работало, поэтому сделал так
        //Если имелось, ввиду, чтобы приложение открывалось, но не работало, значит ошибка в задании
        public static void Main()
        {
            Process[] process = Process.GetProcessesByName("Task_2");
            if (process.Count() > 1)
            {
                process[1].Kill();
            }

            while (mutex.WaitOne())
            {
                Console.WriteLine("Procces run");
                Thread.Sleep(300);
            }

        }
    }
}
