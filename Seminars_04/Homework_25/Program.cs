// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void PrintResult(double result)
{
    Console.Write("A ^ B = ");
    Console.Write(result);
}

double FindDegree(int numberA, int numberB)
{
    double degree = Math.Round(Math.Pow(numberA, numberB));
    return degree;
}

Console.Write("Введите число A: ");
string numberStringA = Console.ReadLine();
int numberUserA = Convert.ToInt32(numberStringA);

Console.Write("Введите число B: ");
string numberStringB = Console.ReadLine();
int numberUserB = Convert.ToInt32(numberStringB);

PrintResult(FindDegree(numberUserA, numberUserB));