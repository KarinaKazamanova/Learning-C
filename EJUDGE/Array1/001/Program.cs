/* Вводится сначала число N, а затем N чисел. Выведите эти N чисел в обратном порядке.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Выходные данные
Выведите N чисел в обратном порядке
*/
using System;
int n = int.Parse(Console.ReadLine());
string  s=Console.ReadLine();
string [] ss = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a = Array.ConvertAll<string, int>(ss, int.Parse);
int temp = 0;
for (int i =0; i < a.Length/2; i++)
{
    temp = a[i]; 
    a[i] = a[a.Length -i -1];
    a[a.Length -i -1] = temp;
}
for (int i =0; i < a.Length; i++)
    System.Console.Write($"{a[i]} ");