using System;

/*
 * конвертация строки
 * класс Convert
 */



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b;
            
            System.Console.WriteLine("Введите число 1: ");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            System.Console.WriteLine("Введите число 2:");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            System.Console.WriteLine("Сумма чисел: " + result);
        }
    }
}
