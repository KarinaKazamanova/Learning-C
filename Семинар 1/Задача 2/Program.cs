﻿Console.WriteLine("Введите число a");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
double b = Convert.ToInt32(Console.ReadLine());

if (a*a == b)
{
    Console.WriteLine(b + " является квадратом " + a);
}
else if (b*b == a)
{
    Console.WriteLine(a + " является квадратом " + b);
}
else 
{
    Console.WriteLine("Квадратов нет");
}