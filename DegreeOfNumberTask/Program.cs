//Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число степени В: ");
int b = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= b; i++)
{
    double result = Math.Pow(a, i);
    Console.WriteLine($"{a}^{i} = {result}");
}