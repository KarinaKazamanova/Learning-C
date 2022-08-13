// Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива
System.Console.WriteLine("Введите количество строк");
int M = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int N = int.Parse(System.Console.ReadLine());
int [,] result = Create2DArray(M, N);
Print (result);
int [,] Create2DArray(int M,int N)
{
    int [,] a = new int [M, N];
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        {
            a[i,j] = i+j;

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