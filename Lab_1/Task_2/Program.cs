/*Виконати минуле завдання, покращивши зовнішній вигляд таблиці із 
вихідними результатами за допомогою символів псевдографіки (┐, ┌,  ┘, └, 
├,  ┤, ┬, ┴ та ін.) та налаштування кольорів консолі, наприклад, числа 
відобразити одним кольором, текст – іншим, таблицю – іншим від 
попередніх. */
using System;
using System.Text;
class Programm
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        string name1, name2, name3;
        string author1, author2, author3;
        int a1, a2, a3;
        char g1, g2, g3;

        Console.WriteLine("1. Введіть: Автор, Назва, Рік, Група >");
        name1 = Console.ReadLine();
        author1 = Console.ReadLine();
        a1 = Convert.ToInt32(Console.ReadLine());
        g1 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("2. Введіть: Автор, Назва, Рік, Група >");
        name2 = Console.ReadLine();
        author2 = Console.ReadLine();
        a2 = Convert.ToInt32(Console.ReadLine());
        g2 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("3. Введіть: Автор, Назва, Рік, Група >");
        name3 = Console.ReadLine();
        author3 = Console.ReadLine();
        a3 = Convert.ToInt32(Console.ReadLine());
        g3 = Convert.ToChar(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("┌───────────────────────────────────────────────┐");
        Console.WriteLine("│  Каталог біблоитеки                           │");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("┌───────────┬───────────┬──────────────┬────────┐");
        Console.WriteLine("│   Назва   │   Автор   │  Рік випуску │ Група  │");
        Console.WriteLine("├───────────┼───────────┼──────────────┼────────┤");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"│ {name1,-9} │ {author1,-9} │ {a1,-12} │ {g1,-6} │");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"│ {name1,-9} │ {author1,-9} │ ");
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.Write($"{a1,-12} │ ");
        Console.ForegroundColor = ConsoleColor.DarkBlue; 
        Console.Write($"{g1,-6} │");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"│ {name3,-9} │ {author3,-9} │ {a3,-12} │ {g3,-6} │");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("└───────────┴───────────┴──────────────┴────────┘");
        Console.ResetColor();

        Console.WriteLine("Примітка: Х – художня література; Н – навчальна література; С – довідкова література");
    }
}