// Выяснить является ли число чётным.
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Введенное число является чётным");
}
else
{
    Console.WriteLine("Введенное число не является чётным");
}