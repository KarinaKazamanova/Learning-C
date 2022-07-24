// Показать кубы чисел, заканчивающихся на четную цифру
double Power3 (double a)
{
    
    a = Math.Pow(a, 3);
    return a;
}
System.Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
double result = 0;
for (int i = 0; i<N; i = i+2)
{
    result = Power3(i);
    System.Console.Write($"{result} "); 

}