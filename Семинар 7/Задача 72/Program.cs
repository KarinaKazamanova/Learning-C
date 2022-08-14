// Написать программу возведения числа А в целую степень B - 3

Random random = new Random();

int N = random.Next(1,11);
int M = random.Next(1,11);

int Power (int n, int m)
{
    if (m==0) return 1;
    else return Power (n,m-1)*n;
}
System.Console.Write($"{N} в степени {M} = ");
System.Console.WriteLine(Power (N,M));