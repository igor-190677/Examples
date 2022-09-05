// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaNumbers(int numberM, int numberN)
{
    if (numberM == numberN) return numberN;
    return numberM + SummaNumbers(numberM + 1, numberN); 
}

Console.Write("Введите натуральное число M: ");
int numbM = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numbN = Convert.ToInt16(Console.ReadLine());

if (numbM < numbN) Console.WriteLine(SummaNumbers(numbM, numbN));
if (numbM > numbN) Console.WriteLine(SummaNumbers(numbN, numbM));