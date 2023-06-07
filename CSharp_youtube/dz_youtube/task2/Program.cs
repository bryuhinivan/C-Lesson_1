// Введите три числа и выведите на экран значение суммы
// и произведения этих чисел.

Console.Clear();

string str;

int a, b, c;

Console.WriteLine("Введите число 1: ");
str = Console.ReadLine();
a = Convert.ToInt32(str);

Console.WriteLine("Введите число 2: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);

Console.WriteLine("Введите число 3: ");
str = Console.ReadLine();
c = Convert.ToInt32(str);

int summ = a + b + c;
int multi = a * b * c;

Console.WriteLine($"Сумма чисел: {summ}");
Console.WriteLine($"Произведение чисел: {multi}");


