using System;
using System.Text;

namespace Task_2
{
    public static class FileRewriter
    {
        public static void StartWriting(string firstPath, string secondPath, string finalPath)
        {
            Thread[] threads = new Thread[2];
            threads[0] = new Thread(ReadAndWriteInfo);
            threads[0].Start(new Tuple<string, string>(firstPath, finalPath));
            threads[0].Join();
            threads[1] = new Thread(ReadAndWriteInfo);
            threads[1].Start(new Tuple<string, string>(secondPath, finalPath));
        }

        private static void ReadAndWriteInfo(object paths)
        {
            StreamReader reader = new StreamReader(((Tuple<string, string>)paths).Item1, Encoding.UTF8);
            StreamWriter writer = new StreamWriter(((Tuple<string, string>)paths).Item2, true, Encoding.UTF8);
            writer.Write(reader.ReadToEnd() + "\n");
            writer.Close();
            reader.Close();
        }
    }
}
