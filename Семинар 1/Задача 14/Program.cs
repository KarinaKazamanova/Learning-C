//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b ==0)
{
    Console.WriteLine("a кратно b");
}
else 
{
    Console.WriteLine("a не кратно b. Остаток от деления a на b равен " + a % b + ".");
}