// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
bool Check1 (double a), Check2 (double b)
{
    return  a > 0;
    return  b > 0;
}
Console.WriteLine("Введите координаты точки");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (Check1(a) && Check2(b))
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (Check(a) && Check (b)))
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else if (Check(b))
{
    Console.WriteLine("Точка находится во второй четверти");
}
else 
{
    Console.WriteLine("Точка находится в третьей четверти");
}