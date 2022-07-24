// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное");
int a = Convert.ToInt32 (Console.ReadLine());
bool Palindrom (int a, out int b, out int c, out int d, out int e)
{
    b = a/10000;
    c = a % 10;
    d = a/1000%10;
    e = a/10%10;
    return b == c && d == e;
}
{
     
}
Palindrom (a, out int b, out int c, out int d, out int e);
if (Palindrom (a,out b, out c, out d, out e) == true)
{
    Console.WriteLine("Введенное число - палиндром");
}
else 
{
    Console.WriteLine("Введенное число - не палиндром");
}
