// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 - 4

Random random = new Random();
int N = random.Next(1,15);

System.Console.WriteLine(N);
System.Console.WriteLine($"Последовательность Фибоначи для {N} введенных чисел");
Febonacci (N);
for (int i = 0; i <= N; i++)
    {
        System.Console.WriteLine(Febonacci(i));
    }
int Febonacci (int N)
{
    if (N==0 || N==1) return 1;
    else 
    {
        return Febonacci (N-1) + Febonacci (N-2); 
        
    }
    
}
