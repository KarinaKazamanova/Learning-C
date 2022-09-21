﻿// Спирально заполнить двумерный массив:
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
    int count = N;
    
    for (int i = 0; i < (M)/2; i++)
    {
        for ( int j = i; j <= count - i; j ++)
        {
            
                
                if (j == (count-1-i))
                {
                    Mtx [i, j] = k;
                    k = k+1;
                    Mtx = Transp(Mtx);
                    if (count == N)
                    {
                        count = M;
                        j = i;
                    }
                    else 
                    {
                        count = N;
                        j = i;
                    } 
                    continue;
                }
                else if (j == (count-2-i) &&  Mtx [i, j +1] != 0)
                {
                    Mtx [i, j] = k;
                    k = k+1;
                    Mtx = Transp(Mtx);
                    if (count == N)
                    {
                        count = M;
                        j = i;
                        
                        
                    }
                    else 
                    {
                        count = N;
                        j = i;
                    } 
                    break;
                }
                else if (j < (count-1-i) &&  Mtx [i, j +1] == 0 )
                {
                    Mtx [i, j] = k;
                    k = k+1;
                    
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
        if (a[i,j] != 0) System.Console.Write($"{a[i,j],4} ");
        else System.Console.Write($"   ");
    System.Console.WriteLine();
    }
}
int [,] Transp(int [,]M )
{
    int [,] N = new int [M.GetLength(1), M.GetLength(0)];
    for (int i = 0; i < M.GetLength(1); i++)
    {
        for (int j = 0; j < M.GetLength(0); j++)
        {
            N [i,j] = M [j,M.GetLength(1)-1-i];
        }
    }
    return N;

}

/*int [,] Spiral ( int M, int N)
{
    int [,] Mtx = new int [M,N];
    int k = 1;
    int count = N;
    for (int i = 0; i < M-1; i++)
    {
        for (int j = 0; j < count; j ++)
        {
            
                if (j < (count-1) &&  Mtx [i, j +1] == 0 )
                {
                    Mtx [i, j] = k;
                    k = k+1;
                }
                else if (j == (count-1))
                {
                     Mtx [i, j] = k;
                    k = k+1;
                    Mtx = Transp(Mtx);
                    if (count == N)
                    {
                        count = M;
                        j = i;
                    }
                    else 
                    {
                        count = N;
                        j = i;
                    } 
                    continue;
                }
                else if (j != (count-1) && Mtx [i, j +1] != 0)
                {
                    Mtx [i, j] = k;
                    k = k+1;
                    Mtx = Transp(Mtx);
                    if (count == N)
                    {
                        count = M;
                        
                        j = i;
                    }
                    else 
                    {
                        count = N;
                        j = i;
                    } 
                    break;
                
                }
                else if (j == (count-2) &&  Mtx [i, j +1] != 0)
                {
                    Mtx = Transp(Mtx);
                    if (count == N)
                    {
                        count = M;
                        
                        j = i;
                    }
                    else 
                    {
                        count = N;
                        j = i;
                    } 
                    continue;
                }
        }
            
         
    }
    return Mtx;
                
}
*/