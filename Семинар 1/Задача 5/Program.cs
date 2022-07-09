// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine("Введите число a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число c");
double c = Convert.ToDouble(Console.ReadLine());

double[] nums = new double[3];
nums[0] = a;
nums[1] = b;
nums[2] = c;
double d = nums.Max<double>();
Console.WriteLine($"Максимальное число = {d}");
