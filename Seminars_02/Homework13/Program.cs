void FindNumber(string number, int index)
{
    char[] Array = number.ToCharArray();

    if (Array.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        Console.Write("Третья цифра в числе: ");
        Console.WriteLine(Array[index]);
    }
}

Console.Write("Ведите число: ");
string number = Console.ReadLine();

FindNumber(number, 2);


