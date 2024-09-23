//Замінити в текстовому рядку кожну кому двома знаками питання; 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        string result = ReplaceComma(input);

        Console.WriteLine($"Результат: {result}");
    }

    static string ReplaceComma(string text)
    {
        int newLength = text.Length;
        foreach (char c in text)
        {
            if (c == ',')
            {
                newLength++; 
            }
        }

        char[] resultArray = new char[newLength];
        int index = 0;

        foreach (char c in text)
        {
            if (c == ',')
            {
                resultArray[index] = '?';
                index++;
                resultArray[index] = '?';
                index++;
            }
            else
            {
                resultArray[index] = c;
                index++;
            }
        }

        return new string(resultArray);
    }
}
