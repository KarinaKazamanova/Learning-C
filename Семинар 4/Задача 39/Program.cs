int N=12; // изменить
int [] a = new int [N];
Random random = new Random (100); // псевдослучайные числа

for (int i=0; i<a.Length; i++)
{
    a[i]=random.Next(-9,10);
}
for (int i=0; i<a.Length; i++)
{
    System.Console.WriteLine($"{a[i], 4}");
}
int s=0;
for (int i=0; i<a; i=i+2)
{
    if (i%2!=0)
    {
        s=s+a[i];
    }
}
System.Console.WriteLine(s);
