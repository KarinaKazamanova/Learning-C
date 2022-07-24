// Вывести на экран кубы чисел от 1 до N

void Power3 (int a)
{
    int i = 0;
    double b = 0;
    while (i <= a)
    {
        b = Math.Pow(i, 3);
        System.Console.Write($"{b} ");
        i++;
    }

}

while (true)
{
    System.Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a >=0)
    {
        Power3(a);
        break;
    }
    else
    {
        System.Console.WriteLine("Введите положительное число");
        continue;
    }

}
