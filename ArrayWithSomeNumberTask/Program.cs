//Определить, присутствует ли в заданном массиве, некоторое число
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
//Console.WriteLine("Введите число для поиска в массиве: ");
//int Num = int.Parse(Console.ReadLine() ?? "");
bool res = false;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 90);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int Num = int.Parse(Console.ReadLine() ?? "");
foreach (int k in array)
{
    if (k == Num)
        res = true;
}
if (res)
    Console.Write($"Число {Num} присутствует в массиве");
else
    Console.Write($"Числа {Num} нет в массиве");