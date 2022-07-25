//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] numbers = new int [123];
Random random = new Random ();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-1000,1001);
}
for (int i=0; i<numbers.Length; i++)
{
    if (i == 0)
    {
        System.Console.Write($"[{numbers[i]}, ");
    }
    else if (i == numbers.Length - 1)
    {
        System.Console.WriteLine($"{numbers[i]},]");
    }
    else
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    
}
int k = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>=10&& numbers[i]<=99)
    {
        k++;
    }
}
System.Console.WriteLine($" Найдено {k} чисел в диапозоне [10,99]");