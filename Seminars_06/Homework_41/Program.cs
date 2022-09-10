// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Comparison(int[] arrayNumbers)
{
    int counter = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if(arrayNumbers[i] > 0 ) counter++; 
    }
    Console.WriteLine();
    Console.WriteLine($"Чисел пользователя больше ноля: {counter}");
}

Console.Write("Сколько чисел вы будете вводить: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

int[] arrayNumbers = new int[number];

arrayNumbers = InputNumbers(arrayNumbers);
Comparison(arrayNumbers);