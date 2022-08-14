// Найти сумму элементов от M до N, N и M заданы - 1
Random random = new Random();

int N = random.Next(1,11);
int M = random.Next(1,11);
if (N > M) 
    {
        int t;
        t=N;
        N=M;
        M=t;
    } 
int SumRec(int n, int m)
{
    if (n < m) return SumRec (n+1,m) + n;
    else return n;
}
System.Console.WriteLine($" ({N}, {M})");
System.Console.WriteLine(SumRec(N,M));