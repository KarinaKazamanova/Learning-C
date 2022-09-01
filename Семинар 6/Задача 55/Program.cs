// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Random random = new Random();
Console.WriteLine("Введите размер матрицы");
string s = Console.ReadLine();
string [] ss = s.Split(' ');
int a = int.Parse(ss[0]);
int b = int.Parse(ss[1]);
int [,] A = Init (a,b);
Print (A);
double [] Res = Average (A);
for (int i=0; i<Res.Length; i++)
{
    System.Console.WriteLine($"{Res[i]} ");
}
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
double [] Average (int[,]A)
{
    double [] Result = new double [A.GetLength(1)];
    double sum = 0;

    for (int i =0; i < A.GetLength(1); i++)
    {
        for (int j =0; j < A.GetLength(0); j++)
        {
            
            sum = sum + A[j,i];
        }
        Result [i] = sum/(A.GetLength(0));
        sum = 0;
    }
    return Result;
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