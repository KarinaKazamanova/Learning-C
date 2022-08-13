// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])
int N =5;
int M =4;
int [,]a;
a = Init(2,3);
Print (a);
Solution(a);
System.Console.WriteLine();
Print(a);
int[,] Solution (int [,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        {
            if (a[i,j]%2==0)
                a[i,j] = -a[i,j];
        }
    }
    return a;
}
int [,] Init(int N, int M)
{
    int[,] a = new int [N,M]; 
    Random random = new Random();
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
