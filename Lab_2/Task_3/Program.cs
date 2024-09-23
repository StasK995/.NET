//Виконати минуле завдання, використовуючи кольорові можливості консолі 
//для покращення інтерфейсу роботи програми. Наприклад, виділяти різними 
//кольорами знайдені в масивах за завданням елементи чи їхні послідовності,
//розраховані параметри, тощо. 
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

       int[] Ar = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            Ar[i] = rand.Next(-100, 100);
        }

        int currentSum = 0;
        int maxSum = 0;
        int start = -1;
        int maxStart = -1;
        int maxEnd = -1;

        for (int i = 0; i < Ar.Length; i++)
        {
            int value = Ar[i];

            if (value > 0)
            {
                if (currentSum == 0)
                {
                    start = i;
                }
                currentSum += value;

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
        for (int i = 0; i < Ar.Length; i++)
        {
            int value = Ar[i];

            if (value > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{value,5}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{value,5}");
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nПослідовність з максимальною сумою:");
       
            for (int i = maxStart; i <= maxEnd; i++)
            {
                int value = Ar[i];
                Console.Write($"{value} ");
            }
            Console.WriteLine($"\nМаксимальна сума: {maxSum}");
        
       

        Console.ResetColor();
    }
}
