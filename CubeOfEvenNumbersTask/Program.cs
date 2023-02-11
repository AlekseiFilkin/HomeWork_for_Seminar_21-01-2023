//Показать кубы чисел, заканчивающихся на четную цифру
int N = new Random().Next(1, 50);
int Num = 1;
Console.WriteLine($"Кубы чисел, заканчивающихся на четную цифру в последовательности от 1 до {N}: ");
while (Num <= N)
{
    var result = Math.Pow(Num, 3);
    if (result % 2 == 0) Console.WriteLine($"{Num}^3 = {result}");
    Num++;
}