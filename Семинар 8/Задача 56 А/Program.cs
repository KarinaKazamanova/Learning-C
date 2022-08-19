// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random random = new Random();
int N = random.Next(1,11);
int M = random.Next(1,11);
int [,] a = Init (N, M);
int [] sum = Sum (a);
Print (a);
System.Console.WriteLine($"{Min(sum)+1} строка");
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
int [] Sum(int [,] a)
{
    int [] b = new int [a.GetLength(0)];
    for (int i=0; i<a.GetLength(0); i++)
    {
        int sum = 0;
        for (int j=0; j<a.GetLength(1);j++)
        {

            sum = sum + a[i,j];
        }
        b[i] = sum;
    }
    return b;    
}
int Min (int [] n)
{
    int min = n[0];
    int g = 0;
    for (int i = 0; i< n.Length; i++)
    if (n [i]< min)
    {
        min = n[i];
        g = i;
    }
    return g;
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