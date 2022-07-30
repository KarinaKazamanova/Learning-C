// Написать программу преобразования десятичного числа в двоичное
int Binar (int a)
{
    int binar = 0;
    double i = 0;
    while (a != 0)
    {
        binar = binar + a%2 * Convert.ToInt32(Math.Pow(10, i));
        a = a/2;
        i++;
    }
    return binar;
}
System.Console.WriteLine("Введите число n");
int n=Convert.ToInt32(Console.ReadLine());
int b = Binar (n);
System.Console.WriteLine($"{n} = {b} в двоичной системе исчисления");