/* Створити квадратну матрицю розміром 9х9. 
 * В індивідуальних завданнях (див. п.6) вказано, 
 * який тип даних використати та яку обробку матриці потрібно виконати. */
using System;

class Program
{
    const int S = 9; 

    static void Main()
    {
        int[,] Ar = new int[S, S]; 
        int k = 1;


        for (int start = 0; start < S; start++)
        {
            int row = start;
            int col = 0;
            while (row >= 0)
            {
                Ar[row, col] = k;
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
                Ar[row, col] = k;
                k++;
                row--;
                col++;
            }
        }


      
        for (int l = 0; l < S; l++)
        {
            for (int r = 0; r < S; r++)
            {
                Console.Write($"{Ar[l, r],4} ");
            }
            Console.WriteLine();
        }
    }
}