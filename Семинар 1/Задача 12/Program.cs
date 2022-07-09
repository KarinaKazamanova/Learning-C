// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
/*
Console.WriteLine("Введите число");
string s = Console.ReadLine();
int[] digmas = new int[s.Length];
for (int i = 0; i < s.Length; i++)
{
    digmas[i] = s[i];
}
int d = digmas.Max<int>();
Console.WriteLine($"Максимальное число = {d}");

!!! Пробовала через массив решить, чтобы код был более универсальным (для любого введенного числа, но с дальнейшим добавлением условия при котором при введении числа вне диапозона выдавалась бы "Error"), но на строчке 8 значения s[i] увеличиваются на 48 при добавлении в массив digmas, соотвественно ответ всегда на 48 больше выходит.

*/
while (true)
{
Console.WriteLine("Введите число в диапозоне [10, 99]");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = a % 10;
if (a > 10 && a < 100)
{    
    if (b >= c)
    {
        Console.WriteLine($"Наибольшая цифра = {b}");
        break;
    }
    else if (b < c)
    {
        Console.WriteLine($"Наибольшая цифра = {c}");
        break;
    }
}
else
{
    Console.WriteLine("Error");
    continue;
}
}