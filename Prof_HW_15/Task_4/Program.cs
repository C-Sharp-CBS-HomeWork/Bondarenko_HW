using System;

namespace Task_4
{
    public class Program
    {
        public static void Main()
        {
            SynchronizationContext.SetSynchronizationContext(new TryCatchSyncContext());
            //SynchronizationContext.SetSynchronizationContext(SynchronizationContext.Current);

            SomeMethod(true); //false 
            Console.ReadKey();
        }

        public async static void SomeMethod(bool error)
        {
            Console.WriteLine("Wait...");
            Thread.Sleep(2000);
            await Task.Run(() =>
            {
                if (error)
                    throw new Exception("MyExeption");
            });
            Console.WriteLine("End");
        }
    }
}
