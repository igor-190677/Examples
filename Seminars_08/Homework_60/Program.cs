// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

void PrintArreyAndIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})  ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int number = 0;
    int[] singleArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                index = 0;
                while (index != 1)
                {
                    number = new Random().Next(1, 100);
                    if (Array.IndexOf(singleArray, number) == -1)
                    {
                        array[i, j, k] = number;
                        singleArray[count] = number;
                        count++;
                        index = 1;
                    }
                }
            }
        }
    }
}

int[,,] arrayUser = new int[2, 2, 2];
FillArray(arrayUser);
PrintArreyAndIndex(arrayUser);
