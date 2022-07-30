// Выяснить являются ли три числа сторонами треугольника
bool Triangle (double a, double b, double c)
{
    bool n;
    n = a<b+c && b < a+c && c < a +b;
    return n;
}

Console.WriteLine("Введите сторону a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите сторону b");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите сторону с");
double c = Convert.ToDouble(Console.ReadLine());


if (Triangle (a,b,c))
{
    System.Console.WriteLine("Введены стороны треугольника");
}
else
{
    System.Console.WriteLine("Введены не стороны треугольника");

}