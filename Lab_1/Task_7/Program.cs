/* Для ряду, члени якого обчислюються за формулою, 
 * відповідною виданому індивідуальному завданню (див. п.6), 
 * знайти суму членів ряду з точністю до 0.000001 і суму перших 10 членів ряду. 
 * Якщо доцільно, можна спростити або перетворити вираз. */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        long n = 0;
        double sum = 0;
        double term;
        const double eps = 0.000001;

        while (true)
        {
            
            double mainPart = (double)((n + 1) * (n + 1)) / ((n + 2) * (n + 2));

            double k2 = 1 - mainPart;

            double k1 = (n % 2 == 0) ? 1 : -1;

            term = k1 * k2;

            if (Math.Abs(term) >= eps)
            {
                sum += term;
            }
            else
            {
                break;
            }

            if (n == 9)
            {
                Console.WriteLine($"Сума 10-ти членів ряду = {sum:F7}");
            }

            n++; 
        }

        Console.WriteLine($"Повна сума ряду = {sum:F7}");
    }
}
