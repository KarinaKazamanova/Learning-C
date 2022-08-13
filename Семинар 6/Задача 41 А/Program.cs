// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.
System.Console.WriteLine("Введите размерность квадратной матрицы одним числом");
int N = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите матрицу");
int [,] a = new int[N,N];
for (int i= 0;i<N;i++)
{
    string s=Console.ReadLine();
    string[] ss= s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j <ss.Length; j++)
        a[i,j] = int.Parse(ss[j]);

}

bool flag = true;
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        if (a[i,j]!=a[j,i])
            {
            flag = false;
            break;
            }
    if (flag)
    {
        break;
    }
    }
}

if (flag)
{
    System.Console.WriteLine("Матрица симметрична");
}
else
{
    System.Console.WriteLine("Матрица не симметрична");

}