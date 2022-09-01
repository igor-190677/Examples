// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void CompletionArray(double[,] ArreyUser)
// {
//     for (int i = 0; i < ArreyUser.GetLength(0); i++)
//     {
//         for (int j = 0; j < ArreyUser.GetLength(1); j++)
//         {
//             double number = new Random().NextDouble() * 10;
//             ArreyUser[i, j] = Math.Round(number, 1);
//         }
//     }
// }

void FindNumberInArray(int[,] arreyUser, int numberUser)
{
    int flagFindNumber = 0;
    for (int i = 0; i < arreyUser.GetLength(0); i++)
    {
        for (int j = 0; j < arreyUser.GetLength(1); j++)
        {
            int number = arreyUser[i,j];
            if (number == numberUser)
            {
                flagFindNumber = 1;
                Console.WriteLine($"Индексы числа {numberUser} в массиве: {i}, {j}");
                break;
            }
        }
    }
    if (flagFindNumber == 0) Console.WriteLine("Такого числа нет в массиве");
}


int[,] userArray = new int[3, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.Write("Введите число: ");
string userNumberString = Console.ReadLine();
int userNumber = Convert.ToInt32(userNumberString);

FindNumberInArray(userArray, userNumber);