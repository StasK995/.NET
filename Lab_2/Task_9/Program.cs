//Визначити номера рядків і стовпців всіх сідлових точок матриці. 
//Матриця А має сідлову точку, якщо A[i][j] є мінімальним елементом в 
//і-у рядку і максимальним в j-у стовпці. 
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Random rand = new Random();
        bool foundSaddlePoint = false;

        while (!foundSaddlePoint)
        {
            int S = 5;
            int[,] Ar = new int[S, S];


            for (int i = 0; i < S; i++)
            {
                for (int j = 0; j < S; j++)
                {
                    Ar[i, j] = rand.Next(1, 100);
                }
            }


            Console.WriteLine("Матриця:");
            for (int l = 0; l < S; l++)
            {
                for (int r = 0; r < S; r++)
                {
                    if (Ar[l, r] % 2 != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write($"{Ar[l, r],4} ");
                }
                Console.WriteLine();
                Console.ResetColor();
            }

            // Пошук
            foundSaddlePoint = false;
            Console.WriteLine("Сідлові точки:");

            // Пошук мінімального значення с рядку
            for (int i = 0; i < S; i++)
            {
                int minRowValue = Ar[i, 0];
                int minColIndex = 0;
                for (int j = 1; j < S; j++)
                {
                    if (Ar[i, j] < minRowValue)
                    {
                        minRowValue = Ar[i, j];
                        minColIndex = j;
                    }
                }

                // Перевірка, чи є мінімальний елемент у рядку максимальним у своєму стовпці
                bool isSaddlePoint = true;
                for (int row = 0; row < S; row++)
                {
                    if (Ar[row, minColIndex] > minRowValue)
                    {
                        isSaddlePoint = false;
                        break;
                    }
                }

                if (isSaddlePoint)
                {
                    Console.WriteLine($"Сідлова точка на позиції ({i}, {minColIndex}) з значенням {minRowValue}");
                    foundSaddlePoint = true; // Знайдено
                }
            }
        }

        Console.WriteLine("Матриця з сідловою точкою знайдена.");
        Console.WriteLine("Пояснення: Матриця А має сідлову точку, якщо A[i][j] є мінімальним елементом в і-у рядку і максимальним в j-у стовпці.");
    }
}