using System;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            FileRewriter.StartWriting(@"First.txt", @"Second.txt", @"Final.txt");
        }
    }
}
