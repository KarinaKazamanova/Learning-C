// Показать натуральные числа от N до 1, N задано
System.Console.WriteLine("Введите число");
int M = int.Parse(System.Console.ReadLine());
Numbers (M);
void Numbers (int N)
{
    if (N == 1) System.Console.Write($"{N} ");
    else 
    {
        System.Console.Write($"{N} ");
        Numbers(N-1); 
        
    } 
}