// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] InputСoefficients(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("Ведите значение k: ");
            else Console.Write("Ведите значение b: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

void FindPointAcross(double[,] array)
{
    double x = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    double y = x * array[0, 0] + array[0, 1];
    Console.WriteLine();
    Console.WriteLine($"Координаты точки пересечения двух прямых: ({x}; {y})");
}

double[,] СoefficientsArray = new double[2, 2];

СoefficientsArray = InputСoefficients(СoefficientsArray);

FindPointAcross(СoefficientsArray);