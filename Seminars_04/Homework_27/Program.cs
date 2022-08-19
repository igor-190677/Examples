// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummaNumbers(string numberUser)
{
    char charOfNumber = 'a';
    int sumNumbers = 0;
    for (int i = 0; i < numberUser.Length; i++)
    {
        charOfNumber = numberUser[i];
        int number = charOfNumber - '0';
        sumNumbers += number;
    }
    return sumNumbers;
}

Console.Write("Введите число A: ");
string numberString = Console.ReadLine();

int result = SummaNumbers(numberString);
Console.WriteLine("Сумма цифр в числе равна: " + result);