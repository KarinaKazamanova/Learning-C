// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
int CountNotNull (double [] a)
{
    int k =0;
    for (int i = 0; i < a.Length; i ++)
    {
        if (a [i] > 0)
        {
            k++;
        }
    }
    return k;
}
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

if (N%100 <20 && N%100 > 10 || N%10 > 4 || N%10 ==0)
{
    System.Console.WriteLine($"Введите {N} чисел");
}
else if (N%10 ==1)
{
    System.Console.WriteLine($"Введите {N} число");   
}
else
{
    System.Console.WriteLine($"Введите {N} числа"); 
}

string? s = Console.ReadLine();
string[] ss = s.Split(" ");
double [] massive = new double [N];
for (int i =0; i < massive.Length; i++)
    massive[i] = double.Parse (ss[i]);
int notnull = CountNotNull (massive);
System.Console.WriteLine(notnull);
