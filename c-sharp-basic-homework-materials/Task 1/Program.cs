using System;
using System.Threading;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(200, 200);
            Console.SetWindowSize(200, 50); //Устанавливаем размеры окна консоли
            Console.CursorVisible = false;

            Matrix instance; //Создание экземпляра класса Matrix
            
            //for (int i = 0; i < 80; i++)
            {
                instance = new Matrix(0); //инициализиция пользовательским конструкторм
                new Thread(instance.Move).Start();//Запускаем метод Move экземпляра класса instance в отдельном потоке
                Thread.Sleep(new Random((int)DateTime.Now.Ticks).Next(10,3000));
            }

            Console.ReadKey();
        }
    }
}
