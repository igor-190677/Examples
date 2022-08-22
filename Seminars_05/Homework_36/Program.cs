// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        int numberA = new Random().Next(0, 10);
        UserArrey[i] = numberA;
    }
    return UserArrey;
}

int SumNumber(int[] numberCells)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < numberCells.Length; i++)
    {
        int result;
        int dev = Math.DivRem(numberCells[i], 2, out result);
        if (result == 1)
        {
            count += numberCells[i];
        }
    }
    return count;
}

ArreyUser = GenerationArray(cells);
PrintArrey(ArreyUser);

int countNumber = SumNumber(ArreyUser);
Console.WriteLine();
Console.WriteLine("Сумма нечетных чисел в массиве: " + countNumber);