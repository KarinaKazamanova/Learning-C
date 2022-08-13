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

int min = a[0,0];
for (int i= 0;i<a.GetLength(0);i++)
{
    for (int j= 0;j<a.GetLength(1);j++)
    {
        if (a[i,j]< min)
        {
        min = a[i,j];
        
        }
    }
}
System.Console.WriteLine(min);