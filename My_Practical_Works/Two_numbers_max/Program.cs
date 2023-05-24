// Задача. Составить алгоритм определения наибольшего числа из 2 рандомных чисел.

Console.Clear();

int numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);

if (numberA > numberB)
Console.WriteLine("Наибольшее число: " + numberA);
if (numberB > numberA)
Console.WriteLine("Наибольшее число: " + numberB);
if (numberA == numberB)
Console.WriteLine("Числа равны и имеют значение: " + numberA);

