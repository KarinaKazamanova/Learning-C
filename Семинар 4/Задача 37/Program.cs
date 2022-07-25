// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] numbers = new int [123];
Random random = new Random ();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100,1000);
}
for (int i=0; i<numbers.Length; i++)
{
    if (i == 0)
    {
        System.Console.Write($"[{numbers[i]}, ");
    }
    else if (i == numbers.Length - 1)
    {
        System.Console.WriteLine($"{numbers[i]}]");
    }
    else
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    
}
int counteven = 0;
int countodd = 0;
for (int i=0; i<numbers.Length; i++)
{
    if (numbers[i]%2 ==0)
    {
        counteven++;
    }
    else
    {
        countodd++;
    }
}
System.Console.WriteLine($"В заданном массиве {counteven} четных чисел и {countodd} нечетных чисел");

