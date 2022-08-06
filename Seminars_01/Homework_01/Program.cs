Console.Write("Введите первое число: ");
string first_string = Console.ReadLine();
int first_number = Convert.ToInt32(first_string);

Console.Write("Введите второе число: ");
string second_string = Console.ReadLine();
int second_number = Convert.ToInt32(second_string);

Console.Write("Максимальное число равно: ");
if (first_number > second_number)
{
    Console.WriteLine(first_number);
}
else
{
    Console.WriteLine(second_number);
}
