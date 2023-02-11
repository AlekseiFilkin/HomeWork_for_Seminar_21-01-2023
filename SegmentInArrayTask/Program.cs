﻿//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов отрезка [10, 99] = {count}");