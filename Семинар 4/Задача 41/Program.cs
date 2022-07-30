// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
string? s=Console.ReadLine();
string[] ss = s.Split(" ");
int [] massive = new int [ss.Length];
for(int i=0;i<massive.Length;i++)
    massive[i]=int.Parse(ss[i]);
int Max (int [] a)
{
    int max = a[0];
    for (int i = 0; i < a.Length; i ++)
    {
        if (max < a [i])
        {
            max = a[i];
        }
    }
    return max;
}
int Min (int [] a)
{
    int min = a[0];
    for (int i = 0; i < a.Length; i ++)
    {
        if (min > a [i])
        {
            min = a[i];
        }
    }
    return min;
}

int b = Max (massive) - Min (massive);
System.Console.WriteLine(b);