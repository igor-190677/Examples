// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)


void PrintArreyAndIndex(int[,,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arrey.GetLength(2); k++)
            {
                Console.Write($"{arrey[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}

void FillArray(int[,,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int k = 0; k < arrey.GetLength(2); k++)
            {
                arrey[i, j, k] = new Random().Next(1, 100);
            }
        }
    }
}

int[,,] arrayUser = new int[2, 2, 2];
FillArray(arrayUser);
PrintArreyAndIndex(arrayUser);