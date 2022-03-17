using System;

namespace Task_3
{
    public class MySyncContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object? state)
        {
            new Thread(() => d.Invoke(state)) { Name = $"{Thread.CurrentThread.ManagedThreadId} Thread" }.Start(); 
        }
    }
}
