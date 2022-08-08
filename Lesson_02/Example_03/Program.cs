void FillArray(int[] numbArray)
{
    int lengthArray = numbArray.Length;
    int index = 0; 
    while (index < lengthArray)
    {
        numbArray[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] nArray)
{
    int lengthArray = nArray.Length;
    int count = 0;
    while (count < lengthArray)
    {
        Console.WriteLine(nArray[count]);
        count++;
    }
}

int FindIndex(int[] Array, int findNumber)
{
    int lengthArray = Array.Length;
    int count = 0;
    int indexNumber = 0;
    while (count < lengthArray)
    {
        if (Array[count] == findNumber)
        {
            indexNumber = count;
            break;
        }
        count++;
    }    
    return indexNumber;
}

int[] numbersArray = new int[10];
int findNumber = 4;

FillArray(numbersArray);
PrintArray(numbersArray);
Console.WriteLine();
int indexNumber = FindIndex(numbersArray, findNumber);
Console.WriteLine("Позици числа " + findNumber + " равна " + indexNumber);
