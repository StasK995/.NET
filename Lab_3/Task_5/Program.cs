//Шифратор
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Введіть текст для шифрування:");
        string input = Console.ReadLine();

        string encryptedText = Encrypt(input);
        Console.WriteLine("Зашифрований текст:");
        Console.WriteLine(encryptedText);

        string decryptedText = Decrypt(encryptedText);
        Console.WriteLine("Розшифрований текст:");
        Console.WriteLine(decryptedText);
    }

    static string Encrypt(string text)
    {
        // Розділити текст на слова
        // Split 
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        return string.Join(" ", words);
    }

    static string Decrypt(string text)
    {
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        return string.Join(" ", words);
    }

    static string ReverseWord(string word)
    {
        char[] charArray = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            charArray[word.Length - 1 - i] = word[i];
        }

        return new string(charArray);
    }
}
