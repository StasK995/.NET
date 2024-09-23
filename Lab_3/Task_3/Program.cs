// Кількість сполучень нн
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть текстовий рядок: ");
        string input = Console.ReadLine();

        string pattern = "нн";

        int count = CountSymbol(input, pattern);
        Console.WriteLine($"Кількість входжень буквосполучення '{pattern}' у рядку: {count}");
    }

    // Функція 
    static int CountSymbol(string text, string pattern)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
        {
            return 0;
        }

        int count = 0;
        int patternLength = pattern.Length;
        int textLength = text.Length;

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            // Substring  початок, довжина = 
            if (text.Substring(i, patternLength) == pattern)
            {
                count++;
            }
        }

        return count;
    }

}
