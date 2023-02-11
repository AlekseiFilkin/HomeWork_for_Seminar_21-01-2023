//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
double max = 0;
double min = 1;
double result;
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    min = array[i];
}
result = max - min;
Console.WriteLine($"Разница между {max} и {min} равна {result}");