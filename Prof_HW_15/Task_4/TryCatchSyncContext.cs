using System;

namespace Task_4
{
    public class TryCatchSyncContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object? state)
        {
            try
            {
                d.Invoke(state);  
            }
            catch (Exception e)
            {
                Console.WriteLine($"opps... {e.Message}");
            }
        }
    }
}
