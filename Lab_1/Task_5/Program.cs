/*Побудувати програму, яка вводить координати точки (x, у) і визначає, 
 * чи потрапляє точка в заштриховану область на малюнку,
 * який відповідає виданому варіанту (див. п.6). 
 * Попадання на межу області вважати попаданням в область.  
 */
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

        if (x >= 0 && x <= 1 && y >= 0 && y <= 1)
        {
            Console.WriteLine("Точка потрапляє в задану область");
        }
        else
        {
            Console.WriteLine("Точка не потрапляє в задану область");
        }
    }
}
