// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.WriteLine("Введите координаты точки");
double c = Convert.ToDouble(Console.ReadLine());
double d = Convert.ToDouble(Console.ReadLine());
bool Check1 (double c)
{
    return c > 0;
}
bool Check2 (double d)
{
    return d > 0;
}    
if (Check1(c) && Check2(d))
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (Check1(c) && !Check2(d))
{
    System.Console.WriteLine("Точка находится в четвертой четверти");
}
else if (!Check1(c) && Check2(d))
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if (!Check1(c) && !Check2(d))
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}