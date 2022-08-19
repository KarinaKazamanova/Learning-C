// Написать программу вычисления функции Аккермана


while (true)
{
    Console.WriteLine("Введите число a");
    int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= 0 && b >= 0)
    {
    System.Console.WriteLine($"Число Аккермана равно {Akkerman (a,b)}");
    break;
    }
    else
    {
        System.Console.WriteLine("Введите целое неотрицательное число или 0");
        continue;
    }
}


int Akkerman (int a, int b)
{
    if (a==0) 
    {
        return b+1;
    }
    else if (a > 0 && b ==0)
    {
        return Akkerman (a-1,1);
    }
    else
    {
        return Akkerman (a-1, Akkerman (a, b-1));
    }
}

