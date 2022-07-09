// Написать программу вычисления значения функции y = sin(a). (Класс Math) (Считаю, что числом вводятся градусы, а не радианы)
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
double angle = Math.PI * a / 180.0;
double b = Math.Sin(angle);
Console.WriteLine(b);