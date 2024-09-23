using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Шляхи до вхідного та вихідного файлів
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        // Зчитування вмісту вхідного файлу і видалення пробілів на початку та в кінці
        string input = File.ReadAllText(inputFilePath).Trim();

        // Видалення дублікованих символів з рядка
        string result = RemoveDuplicateCharacters(input);

        // Запис результату в вихідний файл
        File.WriteAllText(outputFilePath, $"Результат: '{result}'");
    }

    // Метод для видалення дублікованих символів з рядка
    static string RemoveDuplicateCharacters(string str)
    {
        // Перевіряємо, чи рядок порожній або null
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }

        // Використовуємо StringBuilder для створення результату
        StringBuilder result = new StringBuilder();
        char? lastChar = null; // Змінна для збереження останнього символу

        // Проходимо по кожному символу рядка
        foreach (char c in str)
        {
            // Додаємо символ до результату, якщо він не є дублікатом попереднього
            if (c != lastChar)
            {
                result.Append(c);
                lastChar = c; // Оновлюємо останній символ
            }
        }

        // Повертаємо рядок без дублікованих символів
        return result.ToString();
    }
}
