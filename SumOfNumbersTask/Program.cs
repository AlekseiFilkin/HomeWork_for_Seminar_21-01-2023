//Найти сумму чисел от 1 до А
Console.Write("Введите последнее число А: ");
int A = int.Parse(Console.ReadLine() ?? "");
int result = 0;
for (int i = 1; i <= A; i++)
{
    result = i + result;
}
Console.Write($"Сумма всех чисел от 1 до {A} равна: {result}");