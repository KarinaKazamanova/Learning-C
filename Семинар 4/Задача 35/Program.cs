// Написать программу замены элементов массива на противоположные
string? s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] a=new int[ss.Length];
for(int i=0;i<a.Length;i++)
    a[i]=int.Parse(ss[i]);

for(int i=0;i<a.Length;i++)
    a[i] = a[i]*(-1);
for(int i=0;i<a.Length;i++)  
    System.Console.Write(a[i]);