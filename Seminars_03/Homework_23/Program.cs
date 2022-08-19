// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
string numberString = Console.ReadLine();
int numberUser = Convert.ToInt32(numberString);

void PrintArrey(double[] Array)
{
    Console.Write(Array[0]);
    for (int i = 1; i < Array.Length; i++) Console.Write(", " + Array[i]);
}

double[] FindCubes(int number)
{
    double[] numberCubes = new double[number];
    for (int i = 0; i < (number); i++) numberCubes[i] = Math.Round(Math.Pow(i + 1, 3));
    return numberCubes;
}

PrintArrey(FindCubes(numberUser));