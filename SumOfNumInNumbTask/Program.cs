//Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine() ?? "");
int result = 0;
while (Num != 0)
{
	int n = Num%10;
	Num = Num/10;
	result = result+n;
}
Console.WriteLine($"Сумма цифр в заданном числе равна {result}");