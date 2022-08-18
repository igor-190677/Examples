Console.Clear();

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так крсноречивы. Вы дадите мне чаю?";

string ChangeChares(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

Console.WriteLine(text);
Console.WriteLine();
text = ChangeChares(text, 'к', 'К');
Console.WriteLine(text);
Console.WriteLine();
text = ChangeChares(text, 'с', 'С');
Console.WriteLine(text);
