// Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем).
// Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.

Console.Clear();

double UsdToRub = 81.46;
double UsdToUah = 2.21;
double USD;

Console.WriteLine("Введите сумму в USD");

USD = double.Parse(Console.ReadLine());

Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);

Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUah);
