/* Розробити функцію, яка виконує ту обробку символьного рядка, яка визначена у виданому індивідуальному завданні (див. п.6). 
 Вирівнювання по лівому краю*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        Console.Write("Введіть довжину: ");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            // Виклик функції 
            string result = PadLeftAlign(input, length);
            Console.WriteLine($"Рядок вирівняний по лівому краю: '{result}'");
        }
        else
        {
            Console.WriteLine("Введено некоректну довжину.");
        }
    }
    static string PadLeftAlign(string str, int length)
    {
        if (str.Length >= length)
        {
            return str; 
        }

        int spacesToAdd = length - str.Length;

        // Додавання пробілів 
        for (int i = 0; i < spacesToAdd; i++)
        {
            str += " "; 
        }

        return str;
    }
}
