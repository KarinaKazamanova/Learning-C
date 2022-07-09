// Вывести на экран четные числа от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
