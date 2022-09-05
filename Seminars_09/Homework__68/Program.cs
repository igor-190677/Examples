// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AckermannFunc(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if (numberN == 0)
        return AckermannFunc(numberM - 1, 1);
    else
        return AckermannFunc(numberM - 1, AckermannFunc(numberM, numberN - 1)); 
}

Console.Write("Введите число M: ");
int numbM = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число N: ");
int numbN = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(AckermannFunc(numbM, numbN));
