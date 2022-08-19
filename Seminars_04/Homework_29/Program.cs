// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

ArreyUser = GenerationArray(cells);
PrintArrey(ArreyUser);