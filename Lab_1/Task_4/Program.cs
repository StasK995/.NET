/*Виконати минуле завдання, покращивши гнучкість програми обчислення 
виразу, якщо вхідні дані є некоректними із точки зору математичних правил 
(нуль в знаменнику, від’ємне значення під знаком квадратного кореня та ін.). 
Для цього використати механізм обробки відповідних виключень (try … catch 
… finally) 
 */
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        double x, y;
        double a = 12.5;
        double b = 1.3;
        int n = 3; //

        double t1, t2;

        try
        {
            // Ввід
            Console.Write("Введіть значення x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть значення y: ");
            y = Convert.ToDouble(Console.ReadLine());

            // перевірка
            if (n <= 2)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Значення n повинно бути більше 2.");// буде ділення на 0
            }

            // Знаменник t1
            double denominatorT1 = (n - 2) * Math.Pow(x, n - 2);
            if (denominatorT1 == 0)
            {
                throw new DivideByZeroException("Делитель в формулі для t1 є нулем."); // буде ділення на 0
            }

            t1 = 1 / a * ((-1 / denominatorT1) + (b / ((n - 1) * Math.Pow(x, n - 1))));


            t2 = (2 * x / Math.Pow(a, 2)) * Math.Sin(a * x) -
                ((Math.Pow(x, 2) / a - 2 / Math.Pow(a, 3)) * Math.Cos(a * x));

            // Результат
            Console.WriteLine($"t1 = {t1}"); ;
            Console.WriteLine($"t2 = {t2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Помилка вводу даних.");
            Console.WriteLine($"Опис помилки: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка обчислення: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Помилка обчислення: {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Виконання завершено.");
        }
    }
}
