Console.Write("Введите первое число: ");
string first_string = Console.ReadLine();
int number_1 = Convert.ToInt32(first_string);

Console.Write("Введите второе число: ");
string second_string = Console.ReadLine();
int number_2 = Convert.ToInt32(second_string);

Console.Write("Введите третье число: ");
string third_string = Console.ReadLine();
int number_3 = Convert.ToInt32(third_string);

int max_number = number_1;
if (number_2 > max_number)
{
    max_number = number_2;
}
if (number_3 > max_number)
{
    max_number = number_3;
}

Console.WriteLine("Максимальное число равно: " + max_number);