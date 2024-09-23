//Виконати минуле завдання, зробивши матрицю динамічною, задавши її 
//розміри з консолі, використовуючи для цього зубчастий ([][]) двовимірний
//масив.
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.Write("Введіть розмір матриці: ");
        int S = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Розмір: {S}");

        int[][] Ar = new int[S][];
        for (int i = 0; i < S; i++)
        {
            Ar[i] = new int[S];
        }

        int k = 1;

        for (int start = 0; start < S; start++)
        {
            int row = start;
            int col = 0;
            while (row >= 0)
            {
                Ar[row][col] = k;
                k++;
                row--;
                col++;
            }
        }

        for (int start = 1; start < S; start++)
        {
            int row = S - 1;
            int col = start;
            while (col < S)
            {
                Ar[row][col] = k;
                k++;
                row--;
                col++;
            }
        }

        Console.WriteLine("Результат:");
        for (int l = 0; l < S; l++)
        {
            for (int r = 0; r < S; r++)
            {
                Console.Write($"{Ar[l][r],4} ");
            }
            Console.WriteLine();
        }
    }
}
