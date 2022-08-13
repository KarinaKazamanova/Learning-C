
Random random = new Random();
int N = random.Next(1,11);
int M = random.Next(1,11);
int [,] a = Init (N, M);
Print (a);

int [,] Init (int N, int M)
{
    int [,] a = new int [N,M];
    for (int i= 0;i<N;i++)
    {
        for (int j = 0; j <M; j++)
        {
            a[i, j] = random.Next(1,101);
        }
    }
    return a;
}
void Print(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4} ");
    System.Console.WriteLine();
    }
}