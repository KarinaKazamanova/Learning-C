// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
System.Console.WriteLine("Введите количество уровней треугольника Паскаля");
int M = int.Parse(System.Console.ReadLine());
int [,] PascalRes = Pascal (M);
Print (PascalRes);

int[,] Pascal (int M)
{
    int [,] Pascal = new int [M, 2*M-1];
    for (int i=0; i<Pascal.GetLength(0); i++)
    {
        for (int j=0; j<Pascal.GetLength(1);j++)
        { 
            if (i == 0 && j == (Pascal.GetLength(1)-1)/2) Pascal[i,j]=1;
            else if (i!=0 && j !=0 && j != (Pascal.GetLength(1)-1)) Pascal[i,j]= Pascal[i-1,j-1]+Pascal[i-1,j+1];
            else if (i!=0 && j ==0) Pascal[i,j] = Pascal[i-1,j+1];
            else if (i!=0 && j ==(Pascal.GetLength(1)-1)) Pascal[i,j]= Pascal[i-1,j-1];
        }
    }
    return Pascal;

}
void Print(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1);j++)
        if (a[i,j] != 0) System.Console.Write($"{a[i,j],2} ");
        else System.Console.Write($"   ");
    System.Console.WriteLine();
    }
}