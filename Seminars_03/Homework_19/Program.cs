// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string numberUser = Console.ReadLine();

void FindPalindrom(string numberStr)
{
    if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом!");
    }
}

if (numberUser.Length == 5)
{
    FindPalindrom(numberUser);
}
else
{
    Console.WriteLine("Число не является пятизначным!");
}