﻿// Задать массив из 8 элементов и вывести их на экран
int[] temp; // объявление массива
temp = new int [8]; // создаем массив с его типом и размерностью, если new проигнорим, то не будет создан сам массив и останется пустота
/*
temp[0] = 10;
temp[1] = 11;
temp[2] = 15;
*/
for (int i =0; i < temp.Length; i++)
{
    temp[i] = i*10;
}
for (int i =0; i < temp.Length; i++)
{
    System.Console.WriteLine($"temp[{i}]={temp[i]}");
}