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
int sum = 0;
for (int i= 0;i<a.GetLength(0);i++)
{
    sum = sum + a[i,i];
}
System.Console.WriteLine(sum);