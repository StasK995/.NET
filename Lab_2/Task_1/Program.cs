/*Треба оголосити масив цілих чисел і заповнити його випадковими значеннями. 
 * Розмір масиву і діапазон значень його елементів задані у виданому варіанті індивідуального завдання (див. п.6).
 * В індивідуальних завданнях вказано також, яку обробку масиву слід провести. */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        int[] Ar = new int[100];
        Random rand = new Random();

        for (int i = 0; i < Ar.Length; i++)
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
            if (Ar[i] > 0)
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
        Console.WriteLine("Масив : ");
        for (int i = 0; i < Ar.Length; i++)
        {
            Console.Write($"{Ar[i],5}");
        }
        

        Console.WriteLine("\n\nПослідовність з максимальною сумою:");
        for (int i = maxStart; i <= maxEnd; i++)
            Console.Write($"{Ar[i]} ");
        Console.WriteLine($"\nМаксимальна сума: {maxSum}");
    }
}