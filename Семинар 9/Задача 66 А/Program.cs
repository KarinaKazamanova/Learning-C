// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


while (true)
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m >= 0 && n >= 0)
    {
    System.Console.WriteLine($"Число Аккермана равно {Akkerman (m,n)}");
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

// в примере ввода значений и вывода результата функции Аккермана, получается, ошибка, если m = 2, а n = 3, то Akkerman (m, n) = 9, на не 29, значение 29 функция принимает если m = 3, а n = 2