//Найти кубы чисел от 1 до N
Console.Write("Введите последнее число последовательности N: ");
int N = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= N; i++)
{
    double result = Math.Pow(i, 3);
    //int result = i * i * i;
    Console.WriteLine($"{i}^3 = {result}");
}