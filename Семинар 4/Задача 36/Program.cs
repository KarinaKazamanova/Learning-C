// Определить, присутствует ли в заданном массиве, некоторое число
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
int f=400; // изменить
// Линейный поиск
int j=0;
while (j<a.Length && a[j]!=f) j++;
if (j==a.Length) System.Console.WriteLine("Not found");
else System.Console.WriteLine($"Element {f} find at {j}");