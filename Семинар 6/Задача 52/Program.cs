// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

Random random = new Random();
int N = random.Next(1,11);
int M = random.Next(1,11);
int [,] a = Init (N, M);
Print (a);
int [,] result = Quarter (a);
System.Console.WriteLine();
System.Console.WriteLine("Измененная согласно условию матрица");
Print (result);
int [,] Init(int N, int M)
{
    int[,] a = new int [N,M]; 
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        {
            a[i,j] = random.Next(1,11);
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
int [,] Quarter(int[,]a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        {
            if (i%2 ==0 && j%2==0)
            {
                a[i,j] = a[i,j]*a[i,j];
            }
        }
    }
    return a;
}