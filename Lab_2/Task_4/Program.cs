//Виконати минуле завдання, використовуючи замість масивів одну з колекцій 
//мови C# (List,
using System;
using System.Text;


class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        int size;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введіть розмір масиву - ");
        size = Convert.ToInt32(Console.ReadLine());

        List<int> Ar = new List<int>(size);
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            Ar.Add(rand.Next(-100, 100));
        }
        int currentSum = 0;
        int maxSum = 0;
        int start = -1;
        int maxStart = -1;
        int maxEnd = -1;

        for (int i = 0; i < Ar.Count; i++)
        {
            if (Ar[i] >= 0)
            {
                if (currentSum == 0)
                {
                    start = i;
                }
                currentSum += Ar[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxStart = start;
                    maxEnd = i;
                }
            }
            else
            {
                currentSum = 0;
            }



        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Масив : ");
        for (int i = 0; i < Ar.Count; i++)
        {
            if (Ar[i] > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{Ar[i],5}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{Ar[i],5}");
            }
            //Console.Write($"{Ar[i],5}");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nПослідовність з максимальною сумою:");
        for (int i = maxStart; i <= maxEnd; i++)
            Console.Write($"{Ar[i]} ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\nМаксимальна сума: {maxSum}");
        Console.ResetColor();
    }
}