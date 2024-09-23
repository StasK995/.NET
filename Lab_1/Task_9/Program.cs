/* Для функції y = f(x), графік якої наведений у виданому індивідуальному завданні, 
 * вивести на екран значення y для x  = 0, 0.25, 0.5 ... 19.75.
 * Необов’язкова для виконання додаткова вимога – отримати на екрані графік функції з використанням засобів текстового режиму. */
using System;

class Program
{
    static void Main()
    {
        short n;
        double x, y;
        short h;

        for (n = 0; n < 5; n++)
        {
           
            Console.WriteLine("|   x   |      y     |");
            Console.WriteLine("|-------|------------|");

            for (x = 0; x < 4; x += 0.25)
            {
                y = 0;

                if (x <= 1)
                    y = Math.Sqrt(1 - (x - 1) * (x - 1));
                else if (x <= 4)
                    y = -1 / 3.0 * x + 4 / 3.0;

                Console.Write("| {0,5:F2} | {1,10:F7} |", x + n * 4, y);

                h = (short)((y + 1) * 10);
                if (y - 1 - h * 10 > 0.5)
                    h++;

                for (; h > 0; h--)
                    Console.Write(" ");
                Console.WriteLine("*");
            }

            Console.WriteLine("Нажмите клавишу Enter...");
            Console.ReadLine();
        }
    }
}
