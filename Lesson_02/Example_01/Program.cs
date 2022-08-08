int Max(int number1, int number2, int number3)
{
    int maxNumber = number1;
    if (number2 > maxNumber) maxNumber = number2;
    if (number3 > maxNumber) maxNumber = number3;
    return maxNumber;
}

int a1 = 12;
int b1 = 1367;
int c1 = 14;
int a2 = 5;
int b2 = 16234;
int c2 = 170;
int a3 = 18;
int b3 = 1999;
int c3 = 20;

int maxNumber = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine("Макисмальное число равно: " + maxNumber);




