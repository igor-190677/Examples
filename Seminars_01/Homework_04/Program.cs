Console.Write("Введите число: ");
int i_number = int.Parse(Console.ReadLine());

if(i_number <= 1)
{
    Console.Write("Неверный диапазон чисел");
}
else
{
    Console.Write("Четные числа в диапазоне чисел от 1 до " + i_number + ": ");
    for (int number = 2; number < i_number + 1; number += 2)
    {
            if (number == 2)
        {
            Console.Write(number);
        }
        else
        {
            Console.Write(", " + number);
        }
    }
}
