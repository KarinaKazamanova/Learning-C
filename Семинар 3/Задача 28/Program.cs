// Определить количество цифр в числе. Сделать подпрограмму.
int N = Convert.ToInt32(Console.ReadLine());
int CountDigits (int N)
{
    if (N==0) return 1;
    int k = 0;
    while (N!=0)
    {
        k++;
        N = N/10;
    }
    return k;

}

System.Console.WriteLine(CountDigits(N));

// при решении задачи нужно постараться превратить ее в подпрограмму