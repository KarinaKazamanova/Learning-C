// Вывести на экран четные числа от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N)
{
    Console.Write($"{i} ");
    i += 2;
}
