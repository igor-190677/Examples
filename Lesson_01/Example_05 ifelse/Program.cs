var user_name = (string?)null;
Console.Write("Ввведите имя пользователя: ");
user_name = Console.ReadLine();
if(user_name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(user_name);
    Console.WriteLine("!");
}