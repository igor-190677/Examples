int Max(int[] numbers)
{
    int maxNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber) maxNumber = numbers[i];
    }
    return maxNumber;
}

int[] numbers = {12, 130, 14, 5, 16, 177, 18, 1999, 20};

int maxNumber = Max(numbers);

Console.WriteLine("Макисмальное число равно: " + maxNumber);





