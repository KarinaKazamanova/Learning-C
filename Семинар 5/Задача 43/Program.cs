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


void CW (int a)
{
    if (a%100 <20 && a%100 > 10 || a%10 > 4 || a%10 ==0)
    {
        System.Console.Write($" {a} чисел");
    }
    else if (a%10 ==1)
    {
        System.Console.Write($" {a} число");   
    }
    else
    {
        System.Console.Write($" {a} числа"); 
    }
}
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
while (true)
{
    Console.Write("Введите");
    CW(N);
    System.Console.WriteLine("");
    string? s = Console.ReadLine();
    string[] ss = s.Split(" ");
    double [] massive = new double [ss.Length];
    for (int i =0; i < massive.Length; i++)
        massive[i] = double.Parse (ss[i]);
    if (massive.Length == N)
    {
        int notnull = CountNotNull (massive);
        Console.Write("Введено");
        CW (notnull);
        System.Console.WriteLine(" больше 0");
        break;
    } 
    else
    {
        System.Console.WriteLine ("введенно некорректное количество чисел");
        continue;
    }
}