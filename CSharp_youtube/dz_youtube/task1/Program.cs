// Напишите программу, вычисляющую среднее арифметическое двух чисел.

Console.Clear();

string str;

double a, b;

Console.WriteLine("Введите число 1: ");
str = Console.ReadLine();
a = Convert.ToDouble(str);

Console.WriteLine("Введите число 2: ");
str = Console.ReadLine();
b = Convert.ToDouble(str);
double result = (a + b)/2;

Console.WriteLine($"Среднее арифметическиое двух чисел: {result}");