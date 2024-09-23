using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Шляхи до вхідного, вихідного файлів та файлу з шаблоном
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        string patternFilePath = "pattern.txt";

        // Зчитуємо вміст вхідного файлу
        string input = File.ReadAllText(inputFilePath);

        // Зчитуємо шаблон з файлу
        string pattern = File.ReadAllText(patternFilePath);

        // Підраховуємо кількість входжень шаблону у рядку
        int count = CountSymbol(input, pattern);

        // Записуємо результат у вихідний файл
        File.WriteAllText(outputFilePath, $"Кількість входжень буквосполучення '{pattern}' у рядку: {count}");
    }

    // Метод для підрахунку кількості входжень шаблону у тексті
    static int CountSymbol(string text, string pattern)
    {
        // Перевіряємо, чи рядок або шаблон порожні або null
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
        {
            return 0;
        }

        int count = 0; // Лічильник входжень шаблону
        int patternLength = pattern.Length; // Довжина шаблону
        int textLength = text.Length; // Довжина тексту

        // Проходимо по всьому тексту, щоб знайти всі входження шаблону
        for (int i = 0; i <= textLength - patternLength; i++)
        {
            // Перевіряємо, чи підрядок з тексту дорівнює шаблону
            if (text.Substring(i, patternLength) == pattern)
            {
                count++; // Збільшуємо лічильник
            }
        }

        // Повертаємо загальну кількість входжень
        return count;
    }
}
