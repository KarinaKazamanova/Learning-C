// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное");
int a = Convert.ToInt32 (Console.ReadLine());

bool Palindrom (double a)
{
    bool c = (a/10000 == a % 10 && a/1000%10 == a/10%10);
    return c;
}

if (Palindrom (a) == true)
{
    System.Console.WriteLine("Введенное число - палиндром");
}
else 
{
    System.Console.WriteLine("Введенное число - не палиндром");
}
