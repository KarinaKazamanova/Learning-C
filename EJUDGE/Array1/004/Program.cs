﻿/* Вводится число N, а затем - N чисел.
Определить, сколько среди них пар одинаковых чисел.
100>=N>=2
*/
using System;
int n = int.Parse(Console.ReadLine());
string  s=Console.ReadLine();
string [] ss = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a = Array.ConvertAll<string, int>(ss, int.Parse); // первый параметр - из какого типа, второй параметр - в какой тип мы хотим изменить данное
int k = 0;
for (int i = 0; i < a.Length; i++)
    for (int j=i +1;j< a.Length; j++)
    if (a[i] == a[j])
        k++;

System.Console.WriteLine(k);
