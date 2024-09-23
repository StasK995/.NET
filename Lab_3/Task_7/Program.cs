using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Вказуємо шляхи до вхідного, вихідного файлів і файлу з довжиною
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        string lengthFilePath = "length.txt";

        // Зчитуємо вміст вхідного файлу і видаляємо пробіли на початку та в кінці
        string input = File.ReadAllText(inputFilePath).Trim();

        // Перевіряємо, чи існує файл з довжиною
        if (File.Exists(lengthFilePath))
        {
            // Зчитуємо вміст файлу з довжиною і видаляємо пробіли
            string lengthContent = File.ReadAllText(lengthFilePath).Trim();

            // Спробуємо перетворити вміст на ціле число
            if (int.TryParse(lengthContent, out int length))
            {
                // Викликаємо метод для вирівнювання рядка по лівому краю з заданою довжиною
                string result = PadLeftAlign(input, length);

                // Записуємо результат у вихідний файл
                File.WriteAllText(outputFilePath, $"Рядок вирівняний по лівому краю: '{result}'");
            }
            else
            {
                // Якщо перетворення не вдалося, записуємо повідомлення про некоректну довжину
                File.WriteAllText(outputFilePath, "Введено некоректну довжину.");
            }
        }
        else
        {
            // Якщо файл з довжиною не знайдено, записуємо відповідне повідомлення
            File.WriteAllText(outputFilePath, "Файл з довжиною не знайдено.");
        }
    }

    // Метод для вирівнювання рядка по лівому краю з вказаною довжиною
    static string PadLeftAlign(string str, int length)
    {
        // Якщо рядок вже довший або дорівнює вказаній довжині, повертаємо його як є
        if (str.Length >= length)
        {
            return str;
        }

        // Обчислюємо кількість пробілів, які потрібно додати
        int spacesToAdd = length - str.Length;

        // Додаємо пробіли до рядка
        for (int i = 0; i < spacesToAdd; i++)
        {
            str += " ";
        }

        // Повертаємо вирівняний рядок
        return str;
    }
}
