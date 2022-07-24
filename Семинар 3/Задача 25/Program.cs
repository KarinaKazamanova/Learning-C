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


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Power3(a);