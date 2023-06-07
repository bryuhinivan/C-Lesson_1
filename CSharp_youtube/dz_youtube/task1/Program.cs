// Напишите программу, вычисляющую среднее арифметическое двух чисел.

/*
Console.Clear();

string str;

double firstValue, secondValue;

Console.WriteLine("Введите число 1: ");
str = Console.ReadLine();
firstValue = Convert.ToDouble(str);

Console.WriteLine("Введите число 2: ");
str = Console.ReadLine();
secondValue = Convert.ToDouble(str);
double result = (firstValue + secondValue)/2;

Console.WriteLine($"Среднее арифметическиое двух чисел: {result}");
*/


//=====Ещё одно решение

Console.Clear();

double firstValue, secondValue;

Console.WriteLine("Введите число 1: ");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
secondValue = double.Parse(Console.ReadLine());

double result = (firstValue + secondValue) / 2;
Console.WriteLine($"Среднее арифметическое двух чисел = {result}");