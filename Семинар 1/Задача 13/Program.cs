// Удалить вторую цифру целого числа введенного с клавиатуры. (с конца убирала)
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a/100*10 + a % 10;
Console.WriteLine(b);
/* Елси нужно отбросить с начала
int n = 457865;
int k = DidgitsCount(n);
int n2=n%(int)Math.Pow(10,k-2);
int n3=n/(int)Math.Pow(10,k-1);
int nn=n3*(int)Math.Pow(10,k-2) + n2;

int DigitsCount (int n)
{
    if (N==0) return 1;
    int k =0;
    while (N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}
*/