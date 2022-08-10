Console.Write("Ведите первое число: ");
int namberA = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число: ");
int namberB = int.Parse(Console.ReadLine());
int remainder = namberA % namberB;
if (remainder == 0)
{
    Console.Write("Числа являются кратными. Общий делитель равен: ");
    Console.WriteLine(namberA / namberB);
}
else
{
    Console.Write("Числа не являются кратными. Остаток равен: ");
    Console.WriteLine(remainder);
}