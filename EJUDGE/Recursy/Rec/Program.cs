// Вывести числа от 1 до N без циклов
void Loop (int i, int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop (i+1,N);
    else return;
}
Loop(1,10);