/*)  підраховує кількість великих літер у тексті; 
б)  виводить на екран слова, що мають найменшу кількість літер; 
в)  видаляє всі слова, що починаються з малої літери.*/
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Введіть текст для шифрування:");
        string input = Console.ReadLine();

        int uppercaseCount = CountUpperLetters(input);
        Console.WriteLine($"Кількість великих літер: {uppercaseCount}");

      
        SmallNumber(input);
        Console.WriteLine("Текст після видалення слів з маленькою літерою:");
        string result = DeleteSmallLetter(input);
        Console.WriteLine(result);
    }

    static int CountUpperLetters(string text)
    {
        int count = 0;

        foreach (char c in text)
        {

            if ((c >= 'А' && c <= 'Я') || c == 'Є' || c == 'І' || c == 'Ї' || c == 'Й' || c == 'Ґ' || c == 'Ч' || c == 'Ш' || c == 'Щ' || c == 'Ь' || c == 'Ю' || c == 'Я')

            {
                count++;
            }
        }

        return count;
    }

    static void SmallNumber(string text)
    {
        string[] words = text.Split(' ');

        int minLength = int.MaxValue;
        foreach (string word in words)
        {
            if (word.Length < minLength)
            {
                minLength = word.Length;
            }
        }

        Console.WriteLine("Слова з найменшою довжиною:");
        foreach (string word in words)
        {
            if (word.Length == minLength)
            {
                Console.WriteLine(word);
            }
        }
    }

    static string DeleteSmallLetter(string text)
    {
        string[] words = text.Split(' ');
        StringBuilder result = new StringBuilder(); // Використання StringBuilder для накопичення рядків

        foreach (string word in words)
        {
            if (word.Length > 0 && !(word[0] >= 'а' && word[0] <= 'я' || word[0] == 'і')) // перевірка на малу літеру і
            {
                result.AppendFormat("{0} ", word); // Додаємо слово до StringBuilder з використанням AppendFormat
            }
        }

        return result.ToString().Trim(); // Повертаємо результат без зайвого пробілу
    }

}
