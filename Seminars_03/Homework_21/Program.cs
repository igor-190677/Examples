// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] pointA1 = { 3, 6, 8 };
int[] pointB1 = { 2, 1, -7 };
int[] pointA2 = { 7, -5, 0 };
int[] pointB2 = { 1, -1, 9 };


void lengthLine(int[] ArreyA, int[] ArreyB)
{
    double result = Math.Round(Math.Sqrt( Math.Pow((ArreyA[0] - ArreyB[0]), 2) + Math.Pow((ArreyA[1] - ArreyB[1]), 2) + Math.Pow((ArreyA[2] - ArreyB[2]), 2)), 2);
    Console.WriteLine(result);
}

lengthLine(pointA1, pointB1);
lengthLine(pointA2, pointB2);