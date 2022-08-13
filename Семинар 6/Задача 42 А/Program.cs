/* Даны две квадратных таблицы чисел. Требуется построить третью,
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/

System.Console.WriteLine("Введите размерность квадратной матрицы одним числом");
int N = int.Parse(Console.ReadLine());
int [,] a = Init (N, N);
int [,] b = Init (N, N);
int [,] result = SumMatrix (a,b);
Print (result);

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
int [,] SumMatrix (int [,] a,int [,] b )
{
    int[,] c = new int [N,N];
    for (int i=0; i<c.GetLength(0); i++)
    {
        for (int j=0; j<c.GetLength(1);j++)
        {
            c[i,j] = a[i,j] + b[i,j];
        }
    }
    return c;
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