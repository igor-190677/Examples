// Доп. задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] arreyUser)
{
    for (int i = 0; i < arreyUser.GetLength(0); i++)
    {
        for (int j = 0; j < arreyUser.GetLength(1); j++)
        {
            if (arreyUser[i,j] < 10)
            {
                Console.Write($"0{arreyUser[i,j]}  ");
            }
            else
            {
                Console.Write($"{arreyUser[i,j]}  ");
            }
            
        }
    Console.WriteLine();
    }
}

int[,] FillArrey(int[,] arrayUser)
{
    int count = 1;
    int countNumber = 1;

    while (countNumber < arrayUser.Length + 1)
    {
        // движение вправо
        for (int j = count - 1; j < arrayUser.GetLength(1) - count; j++)
        {
            arrayUser[count - 1, j] = countNumber;
            countNumber += 1;
        }
        //движение вниз
        for (int i = count - 1; i < arrayUser.GetLength(0) - count; i++)
        {
            arrayUser[i, arrayUser.GetLength(1) - count] = countNumber;
            countNumber += 1;
        }
        //движение влево
        for (int j = arrayUser.GetLength(1) - count; j > count - 1; j--)
        {
            arrayUser[arrayUser.GetLength(0) - count, j] = countNumber;
            countNumber += 1;
        }
        count += 1;
        //движение вверх
        for (int i = arrayUser.GetLength(0) - count + 1; i > count - 2; i--)
        {
            arrayUser[i, count - 2] = countNumber;
            countNumber += 1;
        }
    }
    return arrayUser;
}

int[,] userArrey = new int[4,4] {{0,0,0,0},{0,0,0,0},{0,0,0,0},{0,0,0,0}};
FillArrey(userArrey);
PrintArray(userArrey);

