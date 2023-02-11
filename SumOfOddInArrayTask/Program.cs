//Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();    
for (int i = 1; i < array.Length; i++)
{
    sum+=array[i];
    i+=1; 
} 
Console.Write($"Сумма нечетных элементов массива равна {sum}");