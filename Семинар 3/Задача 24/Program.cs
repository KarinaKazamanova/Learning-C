//Вывести на экран таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[] square = new int [N];
int i = 0;
for (i = 0; i<N; i = i+1)
{
    square[i] = i*i;
    System.Console.Write($"{square[i]}, ");

}



