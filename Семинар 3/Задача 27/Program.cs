// Возведите число А в натуральную степень B используя цикл

double Pow(double a, int power)
{
    int i =0;
    double b = 1;
    if (power > 0)
    {
        while (i < power)
        {
             b = b * a;
             i++;
        }
    }
    else if (power < 0)
    {
        while (i > power)
        {
             b = b / a;
             i = i - 1;
        }

    }
    else if (power == 1)
    {
        b = a;
    }

    return b;
}
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("В какую степень хотите возвести введенное число (введите целое число, пожалуйста, не помню, как возводить в дробные:(. Можно отрицательные )?");
int power = Convert.ToInt32(Console.ReadLine());
double Result = Pow(a, power);
System.Console.WriteLine($"{a} в степени {power} = {Result}");
