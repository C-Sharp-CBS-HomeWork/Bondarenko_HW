using System;
using System.Diagnostics;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            int[] Arr = new int[1000000];
            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = rnd.Next(10);

            var UnPairArr = from item in Arr.AsParallel()
                            where item % 2 == 1
                            select item;

            foreach (var item in UnPairArr)
            {
                //Console.Write($"{item} ");
            }
        }
    }
}
