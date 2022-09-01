// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] arreyUser)
{
    for (int i = 0; i < arreyUser.GetLength(0); i++)
    {
        for (int j = 0; j < arreyUser.GetLength(1); j++)
        {
            Console.Write($"{arreyUser[i,j]}  ");
        }
    Console.WriteLine();
    }
}

void AverageNumberColumns(int[,] arreyUser)
{
    double summaNumbersColumn = 0;
    double averageNumberColumn = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arreyUser.GetLength(1); j++)
    {
        for (int i = 0; i < arreyUser.GetLength(0); i++)
        {
            summaNumbersColumn += arreyUser[i,j];
        }
        averageNumberColumn = Math.Round(summaNumbersColumn / arreyUser.GetLength(0), 1);
        if (j < arreyUser.GetLength(1) - 1) Console.Write($"{averageNumberColumn}; ");
        if (j == arreyUser.GetLength(1) - 1) Console.Write($"{averageNumberColumn}.");
        summaNumbersColumn = 0;
        averageNumberColumn = 0;
    }
}

int[,] userArray = new int[3, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

PrintArray(userArray);
AverageNumberColumns(userArray);