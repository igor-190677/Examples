// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationArrey(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] resultArray = new int[arrB.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                resultArray[i,j] += arrA[i,k] * arrB[k,j];
            }
        }
    }
    return resultArray;
}

int[,] arreyA = new int[2,2] {{2, 4}, {3, 2}};
int[,] arreyB = new int[2,2] {{3, 4}, {3, 3}};
int[,] arreyC = new int[2,2];

Console.WriteLine("Матрица А:");
PrintArray(arreyA);
Console.WriteLine();
Console.WriteLine("Матрица В:");
PrintArray(arreyB);
Console.WriteLine();
arreyC = MultiplicationArrey(arreyA, arreyB);
Console.WriteLine("Матрица С:");
PrintArray(arreyC);
