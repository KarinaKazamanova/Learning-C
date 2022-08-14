// Найти сумму цифр числа - 2
Random random = new Random();

int N = random.Next(1,100001);

int SumInt (int N)
{
    if (N<10) return N;
    else return SumInt (N/10) + N%10;
}
System.Console.WriteLine(N);
System.Console.WriteLine(SumInt (N));