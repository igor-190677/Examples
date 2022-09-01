// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CompletionArray(double[,] arreyUser)
{
    for (int i = 0; i < arreyUser.GetLength(0); i++)
    {
        for (int j = 0; j < arreyUser.GetLength(1); j++)
        {
            double number = new Random().NextDouble() * 10;
            arreyUser[i, j] = Math.Round(number, 1);
        }
    }
}

void PrintArray(double[,] arreyUser)
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

int stringArray = 3;
int columnsArray = 4;
double[,] userArray = new double[stringArray, columnsArray];

CompletionArray(userArray);
PrintArray(userArray);
