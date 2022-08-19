/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

7 4 2 1

9 5 3 2

8 4 4 2
*/
Random random = new Random();
int N = random.Next(1,11);
int M = random.Next(1,11);
int [,] a = Init (N, M);
Print (a);
System.Console.WriteLine();
int [,] b = Order (a);
Print (b);
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

int[,] Order(int [,]a)
{
    int temp = 0;
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        {
            for (int n = 0; n<a.GetLength(1)-1;n++)
            {
                if (a[i,n] < a[i,n+1])
                {
                    temp = a[i,n];
                    a[i,n] = a[i,n+1];
                    a[i,n+1] = temp;
                }

            }
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

