// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int c = a/10 % 10;
Console.WriteLine(c);