//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
//double max;
//double min;
double result;
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 10;
    Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];

}
result = max - min;
Console.WriteLine($"Разница между {max} и {min} равна {result}");