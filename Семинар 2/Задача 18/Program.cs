// По двум заданным числам проверять является ли одно квадратом другого

/*
Console.WriteLine("Введите число a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b");
double b = Convert.ToDouble(Console.ReadLine());

bool c, d, e;
c = a*a == b;
d = b*b == a;
e = c || d;
if (e && c)
{
    System.Console.WriteLine($"{b} квадрат {a} ");
}
else if (e && d)
{
    System.Console.WriteLine($"{a} квадрат {b} ");
}
else
{
    System.Console.WriteLine("Квадратов нет");
}
Пыталась решить в перерыве

*/
// Ваше решение:
bool Check (double a, double b)
{
    return a*a==b;
}
Console.WriteLine("Введите число a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b");
double b = Convert.ToDouble(Console.ReadLine());

if (Check(a,b))
{
    Console.WriteLine(b + " является квадратом " + a); // пробую разные способы конкатенации
}
else if (Check(b,a))
{
    Console.WriteLine(a + " является квадратом " + b);
}
else 
{
    Console.WriteLine("Квадратов нет");
}

