/* Вводится сначала число N, а затем N чисел. Выведите эти N чисел в обратном порядке.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Выходные данные
Выведите N чисел в обратном порядке
*/
using System;
int n = int.Parse(Console.ReadLine());
string s =Console.ReadLine();
string [] ss = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
string [] b = ss.Reverse;

for (int i=0; i < b.Length; i++)
    System.Console.WriteLine(b[i]);
