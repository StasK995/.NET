//Рядок без повторень
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicateCharacters(input);
        Console.WriteLine($"Результат: '{result}'");
    }

    // Функція для заміни повторюваних символів на один
    static string RemoveDuplicateCharacters(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }

        //  новий рядок без повторюваних символів
        string result = "";
        char? lastChar = null;

        foreach (char c in str)
        {
            if (c != lastChar)
            {
                result += c;
                lastChar = c;
            }
        }

        return result;
    }
}
