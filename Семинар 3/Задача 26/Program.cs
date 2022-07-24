// Найти сумму чисел от 1 до А
int Sum(int a)
{
    int i = 0;
    int b = 0;
    while (i <= a)
    {
        b = b + i;
        i++;   
    }
    return b;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int TotalSum = Sum (a);
System.Console.WriteLine($"Сумма от 1 до {a} = {TotalSum} ");