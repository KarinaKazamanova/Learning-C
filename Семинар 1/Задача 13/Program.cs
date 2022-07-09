// Удалить вторую цифру целого числа введенного с клавиатуры.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a/100}{a % 10}");
