//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[n];
int countEven = 0;
int countOdd = 0;
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
foreach (int i in array)
{
    if (i%2 == 0)
    countEven++;
}
Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
foreach (int i in array)
{
    if (i%2 != 0)
    countOdd++;
}
Console.WriteLine($"Количество нечетных чисел в массиве: {countOdd}");