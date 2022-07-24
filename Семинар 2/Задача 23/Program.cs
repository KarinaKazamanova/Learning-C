// Найти расстояние между точками в пространстве 2D.

Console.WriteLine("Введите координаты первой точки");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
double c = Convert.ToDouble(Console.ReadLine());
double d = Convert.ToDouble(Console.ReadLine());
double Distance (double a, double b, double c, double d)
{
     return Math.Sqrt(Math.Pow((c - a),2) + Math.Pow((d - b), 2));
}


System.Console.WriteLine($"Расстояние между двумя точками равно {Distance(a,b,c,d)}"); 