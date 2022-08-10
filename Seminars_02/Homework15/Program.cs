int[] daysWeekend = new int[] {6, 7};
int weekend  = 0;

Console.Write("Введите день недели: ");
int numberDay = int.Parse(Console.ReadLine());

for (int i = 0; i < daysWeekend.Length; i++)
{
    if (numberDay == daysWeekend[i]) {weekend = numberDay; Console.WriteLine("Да"); break;};
}
if (weekend == 0) {Console.WriteLine("Нет");}