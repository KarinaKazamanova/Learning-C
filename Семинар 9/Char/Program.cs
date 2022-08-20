char c;
System.Char c1; // то же, что и в строчке 1 , UTF - 16 => 1 символ = 2 Байта
c = 'a'; // Для с# 'char' и "string" разный тип данных, соответвенно разные кавычки
System.Console.WriteLine($"{c} {(int)c}");
for (char c2 = 'a'; c2<='z'; c2++)
    System.Console.WriteLine(c2);

if (c>='A' && c<='Z')
{
    System.Console.WriteLine("Big latin char");
}

if (c>='0' && c<='9')
{
    System.Console.WriteLine("char is digit");
}
if (char.IsDigit(c))
{
    System.Console.WriteLine("char is digit");
}

╚  c☺?Ъ