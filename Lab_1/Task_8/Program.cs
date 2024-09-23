/*Виконати минуле завдання, переробивши алгоритм вираховування суми ряду 
таким чином: 
• похибка та кількість членів ряду мають вводитися як вхідні параметри 
у відповідні змінні; 
• сума ряду вираховується або при досягненні заданої похибки, або при 
досягненні заданої кількості членів ряду із видачою відповідного 
повідомлення.  */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.Write("Введіть поріг помилки (eps): ");
        double eps = double.Parse(Console.ReadLine());

        Console.Write("Введіть максимальну кількість членів: ");
        int maxTerms = int.Parse(Console.ReadLine());

        long n = 0;
        double sum = 0;
        double term;

        while (n < maxTerms)
        {
            double mainPart = (double)((n + 1) * (n + 1)) / ((n + 2) * (n + 2));

            double k2 = 1 - mainPart;

            double k1 = (n % 2 == 0) ? 1 : -1;

            term = k1 * k2;

            sum += term;

            if (Math.Abs(term) < eps)
            {
                Console.WriteLine($"Порогу помилки досягнуто. Сума ряду = {sum:F7}");
                break;
            }

            n++;
        }
        if (n == maxTerms)
        {
            Console.WriteLine($"Максимальна кількість членів ряду ({maxTerms}) досягнуто. Сума ряду = {sum:F7}");
        }
    }
}
