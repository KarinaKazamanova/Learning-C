// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
bool Check (double a)
{
    return a == 7 || a == 6;
}
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
if (Check(a))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний");
}