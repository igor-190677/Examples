// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int cells = 8;
int[] ArreyUser = new int[cells];

void PrintArrey(int[] Array)
{
    Console.Write("[" + Array[0]);
    for (int i = 1; i < Array.Length; i++) Console.Write(", " + Array[i]);
    Console.Write("]");
}

int[] GenerationArray(int numberCells)
{
    int[] UserArrey = new int[numberCells];
    for (int i = 0; i < numberCells; i++)
    {
        int numberA = new Random().Next(100, 1000);
        UserArrey[i] = numberA;
    }
    return UserArrey;
}

int CountNumber(int[] numberCells)
{
    int count = 0;
    double remainder = 0;
    for (int i = 0; i < numberCells.Length; i++)
    {
        remainder = Math.IEEERemainder(numberCells[i], 2);
        if (remainder == 0)
        {
            count++;
        }
    }
    return count;
}

ArreyUser = GenerationArray(cells);
PrintArrey(ArreyUser);

int countNumber = CountNumber(ArreyUser);
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: " + countNumber);