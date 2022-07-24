// Подсчитать сумму цифр в числе
int CountDigits (int N)
{
    if (N==0) return 0;
    int k = 0;
    int b = 0;
    int a = 0;
    while (N!=0)
    {
        k++;
        a = N%10;
        N = N/10;
        b = b + a;
    }
    return b;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = CountDigits (N);
System.Console.WriteLine($"Сумма чисел введенного числа равна {Sum}");