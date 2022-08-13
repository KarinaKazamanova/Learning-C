// SВ матрице найти номер строки, сумма чисел в которой наибольшая

string s = System.Console.ReadLine();
int N = int.Parse(s.Split(' ')[0]);
int M = int.Parse(s.Split(' ')[1]);
int [,] a = new int[N,M];
for (int i= 0;i<N;i++)
{
    s=Console.ReadLine();
    string[] ss= s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j <ss.Length; j++)
        a[i,j] = int.Parse(ss[j]);

}
Print (a);



void Print(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4} ");
    System.Console.WriteLine();
    }
}
