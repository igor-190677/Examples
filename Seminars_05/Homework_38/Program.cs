// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        int numberA = new Random().Next(0, 100);
        UserArrey[i] = numberA;
    }
    return UserArrey;
}

int DifMaxMin(int[] numberCells)
{
    int min = numberCells[0];
    int max = numberCells[0];
    for (int i = 1; i < numberCells.Length; i++)
    {
        if (max < numberCells[i]) max = numberCells[i];
        if (min > numberCells[i]) min = numberCells[i];
    }
    int difMinMax = max - min;
    return difMinMax;
}

ArreyUser = GenerationArray(cells);
PrintArrey(ArreyUser);

int difNumberMaxMin = DifMaxMin(ArreyUser);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным числами массива: " + difNumberMaxMin);