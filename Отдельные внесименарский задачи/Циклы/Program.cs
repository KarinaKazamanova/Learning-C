int i = 0;
int N = 10;
while (i<N) // пока универсальный
{
    i=i+1;
    System.Console.WriteLine($"{i} ");
}

// цикл for
for (i = 0; i<N; i = i+1)
{
    System.Console.WriteLine($"{i} ");
}
// do
int a =0;
do
{
    System.Console.WriteLine("Введите положительное число");
    int a = Convert.ToInt32(Console.ReadLine());

}
while (a<= 0);
