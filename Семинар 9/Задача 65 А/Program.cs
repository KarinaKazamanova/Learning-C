// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());


if (m>n)
{
    int temp = 0;
    temp = m;
    m = n;
    n = temp;
}
System.Console.WriteLine(Sum (m, n));

int Sum (int m, int n)
{
    int sum =0;
    if (m==n) return sum = sum + n;
    else return sum = sum + Sum(m +1, n) +m;
}