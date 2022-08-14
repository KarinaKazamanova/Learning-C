// Вывести числа от 1 до N без циклов
void Loop (int i, int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop (i+1,N);
}
Loop(1,10);

int F (int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}
System.Console.WriteLine(F(5));
// Любую рекурсию можно заменить рекурсионным алгоритмом!!! (но рекурсия иногда лучше)