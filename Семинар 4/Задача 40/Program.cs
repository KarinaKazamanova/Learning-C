﻿// Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N=12; // изменить
int [] a = new int [N];
Random random = new Random (); // псевдослучайные числа

for (int i=0; i<a.Length; i++)
{
    a[i]=random.Next(-9,11);
}
for (int i=0; i<a.Length; i++)
{
    System.Console.WriteLine($"{a[i], 4}");
}

int [] b = new int[a.Length/2];
for (int i=0; i<a.Length/2; i++)
{
    b[i]=a[i]*a[a.Length-i-1];
}
System.Console.WriteLine();
for (int i=0; i<b.Length; i++)
{
    System.Console.WriteLine($"{b[i],4}"); 
}