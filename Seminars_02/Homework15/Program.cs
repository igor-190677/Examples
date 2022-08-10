void FindWeekend(int[] Array, int day)
{
    int weekend  = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (day == Array[i]) {weekend = day; Console.WriteLine("Да"); break;};
    }
    if (weekend == 0) {Console.WriteLine("Нет");}
}

int[] daysWeekend = new int[] {6, 7};

Console.Write("Введите день недели: ");
int numberDay = int.Parse(Console.ReadLine());

FindWeekend(daysWeekend, numberDay);