// Показать числа Фибоначчи


int [] Fibonacci (int a)
{
    int [] FibonacciNumbers = new int [a];
    if (a>2)
    {
        FibonacciNumbers [0] = 0;
        FibonacciNumbers [1] = 1;
        int i = 2;
        while (i < a)
            {
                FibonacciNumbers [i] = FibonacciNumbers [i-1] + FibonacciNumbers [i - 2];
                i++;
            }
    }
    else if (a == 1)
    {
       FibonacciNumbers [0] =0;
    }
    else if (a == 2)
    {
        FibonacciNumbers [0] = 0;
        FibonacciNumbers [1] = 1;
    }
    return FibonacciNumbers;
}
void CW (int a)
{
    if (a%10 ==1 && a%100 != 11)
    {
        System.Console.Write($" {a} числа");
    }
    else
    {
        System.Console.Write($" {a} чисел");
    } 
}

Console.WriteLine("Сколько знаков в последовательности Фибоначчи Вы бы хотели увидеть?");
int a = Convert.ToInt32(Console.ReadLine());
int [] F = new int [a];
F = Fibonacci (a);
System.Console.Write("Последовательность Фибоначчи из");
CW(a);
System.Console.WriteLine(":");
for (int i =0; i < F.Length; i++)
{
    System.Console.WriteLine($"{F[i]}");
}