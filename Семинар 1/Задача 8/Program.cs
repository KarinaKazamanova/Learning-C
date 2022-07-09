// Вывести на экран числа от -N до N (считала, что от -N до N включительно и нужен вывод только целых чисел)
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i <= N)
{
    Console.Write(i + ", ");
    i++;
}
