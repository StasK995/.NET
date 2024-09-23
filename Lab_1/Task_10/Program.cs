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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|   x   |      y     |");
            Console.WriteLine("|-------|------------|");

            for (x = 0; x < 4; x += 0.25)
            {
                y = 0;

                if (x <= 1)
                    y = Math.Sqrt(1 - (x - 1) * (x - 1));
                else if (x <= 4)
                    y = -1 / 3.0 * x + 4 / 3.0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("| {0,5:F2} | {1,10:F7} |", x + n * 4, y);

                h = (short)((y + 1) * 10);
                if (y - 1 - h * 10 > 0.5)
                    h++;

                Console.ForegroundColor = ConsoleColor.Red;
                for (; h > 0; h--)
                    Console.Write(" ");
                Console.Write("|"); 
                Console.WriteLine();

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите клавишу Enter...");
            Console.ReadLine();
        }

        Console.ResetColor();
    }
}
