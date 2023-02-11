//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int result = 1;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length / 2; i++)
{
    result = array[i] * array[array.Length - i - 1];
    Console.WriteLine($"{array[i]} * {array[array.Length - i - 1]} = {result}");
}