/* Вводится сначала число N, а затем N чисел. Выведите эти N чисел в следующем порядке: сначала выводятся все нечетные числа в том порядке, в каком они встречались во входном файле, а затем - все четные. Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer
*/
using System;
double n = double.Parse(Console.ReadLine());
string  s=Console.ReadLine();
string [] ss = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
double[] a = Array.ConvertAll<string, double>(ss, double.Parse);

for (int i = 0; i < a.Length; i ++)
    if (a[i]%2 !=0)
        System.Console.Write($"{a[i]} ");
for (int i = 0; i < a.Length; i ++)
    if (a[i]%2 ==0)
        System.Console.Write($"{a[i]} ");
   