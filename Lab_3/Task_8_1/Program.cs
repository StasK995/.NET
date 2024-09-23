using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Шлях до бінарного файлу
        string filePath = "output.bin";

        // Зчитування рядка з консолі
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        // Заміна ком в рядку на два символи '?'
        string result = ReplaceComma(input);

        // Запис результату у бінарний файл
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(result); // Записуємо рядок у файл
        }

        // Читання результату з бінарного файлу
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            string readResult = reader.ReadString(); // Читаємо рядок з файлу
            Console.WriteLine($"Результат з файлу: {readResult}"); // Виводимо результат на консоль
        }
    }

    // Метод для заміни ком у рядку на два символи '?'
    static string ReplaceComma(string text)
    {
        // Обчислюємо нову довжину рядка, враховуючи подвоєння ком
        int newLength = text.Length;
        foreach (char c in text)
        {
            if (c == ',')
            {
                newLength++; // Збільшуємо довжину на одиницю для кожної коми
            }
        }

        // Створюємо масив символів для результату з новою довжиною
        char[] resultArray = new char[newLength];
        int index = 0;

        // Проходимо по кожному символу вихідного рядка
        foreach (char c in text)
        {
            if (c == ',')
            {
                // Замінюємо кому на два символи '?'
                resultArray[index] = '?';
                index++;
                resultArray[index] = '?';
                index++;
            }
            else
            {
                // Копіюємо інші символи без змін
                resultArray[index] = c;
                index++;
            }
        }

        // Повертаємо новий рядок з заміненими комами
        return new string(resultArray);
    }
}
