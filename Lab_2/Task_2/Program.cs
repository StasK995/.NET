//Виконати минуле завдання, зробивши похідний масив динамічним, задавши 
//його розмір з консолі. 
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        int size;
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

        Console.WriteLine("Масив : ");
        for (int i = 0; i < Ar.Length; i++)
        {
            Console.Write($"{Ar[i],5} ");
        }

        Console.WriteLine("\n\nПослідовність з максимальною сумою:");

        for (int i = maxStart; i <= maxEnd; i++)
        {
            Console.Write($"{Ar[i]} ");
        }
            Console.WriteLine($"\nМаксимальна сума: {maxSum}");
        
           
        }
    }

