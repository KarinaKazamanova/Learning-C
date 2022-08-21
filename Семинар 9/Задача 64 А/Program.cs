//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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

void Numbers(int m, int n)
{
    if (m==n-1) System.Console.Write($"{m} ");
    else  Numbers (m, n-1); System.Console.Write($"{n} ");
}

Numbers (m, n);