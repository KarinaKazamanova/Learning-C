// Вывести на экран последнюю цифру целого числа введенного с клавиатуры
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
Console.WriteLine(b);