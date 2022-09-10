// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CounterNumbers(int numb)
{
    int numberUser = 0;
    int counter = 0;
    for (int i = 0; i < numb; i++)
    {
        Console.Write("Введите отрицательное или положительное целое число: ");
        numberUser = Convert.ToInt16(Console.ReadLine());
        if (numberUser > 0) counter++;
    }
    Console.WriteLine();
    Console.WriteLine($"Чисел пользователя больше ноля: {counter}");
}

Console.Write("Сколько чисел вы будете вводить: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

CounterNumbers(number);