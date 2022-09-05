// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] arrayUser)
{
    for (int i = 0; i < arrayUser.GetLength(0); i++)
    {
        for (int j = 0; j < arrayUser.GetLength(1); j++)
        {
            Console.Write($"{arrayUser[i,j]}  ");
        }
    Console.WriteLine();
    }
}

void FindStingWithMinSumNumbers(int[,] arrayUser)
{
    int[] singleArray = new int[arrayUser.GetLength(1)];
    int minSumNumbersString = 0;
    int sumNumbersString = 0;

    for (int j = 0; j < arrayUser.GetLength(1); j++) minSumNumbersString += arrayUser[0, j];
    for (int j = 0; j < arrayUser.GetLength(1); j++) singleArray[j] = arrayUser[0, j];

    for (int i = 1; i < arrayUser.GetLength(0); i++)
    {
        sumNumbersString = 0;
        for (int j = 0; j < arrayUser.GetLength(1); j++) sumNumbersString += arrayUser[i, j];
        if (sumNumbersString < minSumNumbersString)
        {
            for (int k = 0; k < arrayUser.GetLength(1); k++) singleArray[k] = arrayUser[i, k];
        }
    }
    for (int i = 0; i < singleArray.GetLength(0); i++) Console.Write($"{singleArray[i]}  ");
}

int[,] userArray = new int[4, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

Console.WriteLine("Массив:");
PrintArray(userArray);
Console.WriteLine();
Console.WriteLine("Строка с минимальной суммой чисел:");
FindStingWithMinSumNumbers(userArray);