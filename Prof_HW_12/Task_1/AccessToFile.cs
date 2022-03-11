using System;
using System.Text;

namespace Task_1
{
    public class AccessToFile : IDisposable
    {
        private bool _disposed = false;
        private Mutex _mutex;
        private StringBuilder _sb;

        public AccessToFile()
        { 
            _sb = new StringBuilder();
            _mutex = new Mutex(false,"AccessToLog");
            _sb.AppendLine($"Thread {Thread.CurrentThread.Name} start work info file");
            GC.SuppressFinalize(this);
        }
        public void WriteInfo(string info)
        {
            _sb.AppendLine($"Thread {Thread.CurrentThread.Name} write {info} into file");
        }

        public void Dispose()
        {
            if (_disposed)
                return;
            _sb.AppendLine($"Thread {Thread.CurrentThread.Name} end work with file");
            _mutex.WaitOne();
            WriteIntoLog();
            _mutex.ReleaseMutex();
            _disposed = true;
        }

        private void WriteIntoLog()
        {
            byte[] infobyte = Encoding.UTF8.GetBytes(_sb.ToString().ToArray());
            using FileStream file = new FileStream(@"Text.log", FileMode.Append, FileAccess.Write, FileShare.Write);
            file.Write(infobyte);
        }
    }
}
