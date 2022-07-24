// Написать программу вычисления произведения чисел от 1 до N
int Product(int a)
{
    int i = 1;
    int b = 1;
    while (i <= a)
    {
        b = b*i;
        i++;   
    }
    return b;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int TotalProduct = Product(a);
System.Console.WriteLine($"Произведение чисел от 1 до {a} = {TotalProduct}");