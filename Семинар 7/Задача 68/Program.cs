// Показать натуральные числа от M до N, N и M заданы

System.Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

if (M>N)
{
    int temp = 0;
    temp = M;
    M = N;
    N = temp;
}
Numbers (M, N);
void Numbers(int m, int n)
{
    if (m==n-1) System.Console.Write($"{m} ");
    else  Numbers (m, n-1); System.Console.Write($"{n} ");
}
