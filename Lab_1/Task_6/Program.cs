/*Виконати минуле завдання без використання оператору if у будь-яких 
формах */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        double x, y;

        Console.Write("Введіть координату x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"x={x,6:F3};  y={y,6:F3}");

        // Тернальний оператор
        string result = (x >= 0 && x <= 1 && y >= 0 && y <= 1)
            ? "Точка потрапляє в задану область"
            : "Точка не потрапляє в задану область";

        Console.WriteLine(result);
    }
}
