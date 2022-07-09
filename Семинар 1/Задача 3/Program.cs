// С клавиатуры вводятся два числа a и b. Найти максимальное из них. 
Console.WriteLine("Введите первое число");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double b = Convert.ToDouble(Console.ReadLine());


if (b > a)
{
    Console.WriteLine($"Маскимальное {b}");
}
else if (b < a)
{
    Console.WriteLine($"Маскимальное {a}");
}
else 
{
    Console.WriteLine($"Маскимального нет, числа равны");
}