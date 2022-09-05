// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int PrintNumbers(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        Console.Write($"{numberN}");
        return numberN;
    }
    else
    {
        Console.Write($"{numberM}, ");
        PrintNumbers(numberM + 1, numberN);
        return numberM;
    }
}

Console.Write("Введите натуральное число M: ");
int numbM = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numbN = Convert.ToInt16(Console.ReadLine());

if (numbM < numbN) PrintNumbers(numbM, numbN);
if (numbM > numbN) PrintNumbers(numbN, numbM);