// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortNumbersSting(int[,] arrayUser)
{
    int[,] sortArray = new int[arrayUser.GetLength(0), arrayUser.GetLength(1)];
    int[] singleArray = new int[arrayUser.GetLength(1)];
    for (int i = 0; i < arrayUser.GetLength(0); i++)
    {
        
        for (int j = 0; j < arrayUser.GetLength(1); j++)
        {
            singleArray[j] = arrayUser[i, j];
        }
        Array.Sort(singleArray);
        Array.Reverse(singleArray);
        for (int k = 0; k < singleArray.Length; k++) sortArray[i, k] = singleArray[k];
    }
    return sortArray;
}

int[,] userArray = new int[3, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.WriteLine("Исходный массив:");
PrintArray(userArray);
Console.WriteLine();

int[,] sortedArray = new int[3, 4];

sortedArray = SortNumbersSting(userArray);
Console.WriteLine("Отсортированный массив:");
PrintArray(sortedArray);