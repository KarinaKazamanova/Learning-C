// Показать натуральные числа от 1 до N, N задано

System.Console.WriteLine("Введите число");
int M = int.Parse(System.Console.ReadLine());
Numbers (M);
void Numbers (int N)
{
    if (N == 1) System.Console.Write($"{N} ");
    else 
    {
        Numbers(N-1); 
        System.Console.Write($"{N} ");
    } 
}