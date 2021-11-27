using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your msg: ");
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Green);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Black);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Blue);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Gray);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Red);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.White);
            ColorPrint.Print("SPAM!!!", (int)EnumColor.Yellow);
        }
    }
}
