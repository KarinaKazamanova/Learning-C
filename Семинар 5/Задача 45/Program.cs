// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы





void Riddle (double b1, double b2, double k1, double k2)
{
    if (k1==k2)
    {
        System.Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k2 * x + b2;  //можно y = k1 * x + b1, что тоже верно
        System.Console.WriteLine($"Координаты точки пересечения: ({x}; {y})");
    }
}

Console.WriteLine("Введите коэффициент k1 при x1 для y1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите свободный член b1 для y1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2 при x2 для y2");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите свободный член b2 для y2");
double b2 = Convert.ToDouble(Console.ReadLine());

Riddle(b1, b2, k1, k2);