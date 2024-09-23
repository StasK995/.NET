using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Шляхи до бінарних файлів для зберігання зашифрованого і дешифрованого тексту
        string filePath1 = "Encrypt.bin";
        string filePath2 = "Decrypt.bin";

        // Зчитування тексту з консолі для шифрування
        Console.Write("Введіть текст для шифрування:");
        string input = Console.ReadLine();

        // Шифрування тексту
        string encryptedText = Encrypt(input);

        // Запис зашифрованого тексту в бінарний файл
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath1, FileMode.Create)))
        {
            writer.Write(encryptedText);
        }

        // Читання зашифрованого тексту з бінарного файлу для перевірки
        using (BinaryReader reader = new BinaryReader(File.Open(filePath1, FileMode.Open)))
        {
            string readResult = reader.ReadString();
            Console.WriteLine($"Зашифрований результат з файлу: {readResult}");
        }

        // Дешифрування тексту
        string decryptedText = Decrypt(encryptedText);

        // Запис дешифрованого тексту в інший бінарний файл
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath2, FileMode.Create)))
        {
            writer.Write(decryptedText);
        }

        // Читання дешифрованого тексту з бінарного файлу для перевірки
        using (BinaryReader reader = new BinaryReader(File.Open(filePath2, FileMode.Open)))
        {
            string readResult = reader.ReadString();
            Console.WriteLine($"Дешифрований результат з файлу: {readResult}");
        }
    }

    // Метод для шифрування тексту (зворотній порядок слів)
    static string Encrypt(string text)
    {
        // Розділяємо текст на слова за пробілами
        string[] words = text.Split(' ');

        // Реверсуємо кожне слово
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        // Об'єднуємо слова назад в рядок з пробілами
        return string.Join(" ", words);
    }

    // Метод для дешифрування тексту (зворотній порядок слів, так само як у шифруванні)
    static string Decrypt(string text)
    {
        // Розділяємо текст на слова за пробілами
        string[] words = text.Split(' ');

        // Реверсуємо кожне слово
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        // Об'єднуємо слова назад в рядок з пробілами
        return string.Join(" ", words);
    }

    // Метод для реверсування символів у слові
    static string ReverseWord(string word)
    {
        char[] charArray = new char[word.Length];
        int index = 1;

        // Проходимо по кожному символу в слові
        foreach (char c in word)
        {
            // Розміщуємо символи в зворотному порядку
            charArray[word.Length - index] = c;
            index++;
        }

        // Повертаємо нове слово у зворотному порядку
        return new string(charArray);
    }
}
