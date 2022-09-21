// Спирально заполнить двумерный массив:
System.Console.WriteLine("Введите количество строк в матрице");
int M = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в матрице");
int N = int.Parse(System.Console.ReadLine());
int [,] SpinMtx = Spiral ( M, N);
Print (SpinMtx);

int [,] Spiral ( int M, int N)
{
    int [,] Mtx = new int [M,N];
    int k = 1;
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j ++)
        {
            while (true)
            {
                if ( Mtx [i, j +1] != 0)
                {
                    int temp = 0;
                    temp = i;
                    i = j;
                    j = temp;
                    
                    
                }
                else 
                {
                    Mtx [i, j] = k;
                    k = k+1;
                }
            }
        }
    }
    return Mtx;
}
void Print(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        if (a[i,j] != 0) System.Console.Write($"{a[i,j],2} ");
        else System.Console.Write($"   ");
    System.Console.WriteLine();
    }
}