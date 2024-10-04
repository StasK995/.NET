using System;
using System.Text;

class Programm
{
    static void Main()
    {
        // кодування Unicode для введення та виведення
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        string name1, name2, name3;
        string author1, author2, author3;
        int a1, a2, a3;
        char g1, g2, g3;

        // Читаємо введення з консолі
        Console.WriteLine("1. Введіть: Автор, Назва, Рік, Група >");
        name1 = Console.ReadLine();
        author1 = Console.ReadLine();
        a1 = Convert.ToInt32(Console.ReadLine());
        g1 = Convert.ToChar(Console.Read()); // Читаємо символ для групи
        Console.ReadLine(); // Пропускаємо залишки буфера після введення символу

        Console.WriteLine("2. Введіть: Автор, Назва, Рік, Група >");
        name2 = Console.ReadLine();
        author2 = Console.ReadLine();
        a2 = Convert.ToInt32(Console.ReadLine());
        g2 = Convert.ToChar(Console.Read());
        Console.ReadLine(); // Пропускаємо залишки буфера

        Console.WriteLine("3. Введіть: Автор, Назва, Рік, Група >");
        name3 = Console.ReadLine();
        author3 = Console.ReadLine();
        a3 = Convert.ToInt32(Console.ReadLine());
        g3 = Convert.ToChar(Console.Read());
        Console.ReadLine(); // Пропускаємо залишки буфера

        // Виведення таблиці з псевдографікою
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("┌───────────────────────────────────────────────┐");
        Console.WriteLine("│  Каталог бібліотеки                           │");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("┌───────────┬───────────┬──────────────┬────────┐");
        Console.WriteLine("│   Назва   │   Автор   │  Рік випуску │ Група  │");
        Console.WriteLine("├───────────┼───────────┼──────────────┼────────┤");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"│ {name1,-9} │ {author1,-9} │ {a1,-12} │ {g1,-6} │");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"│ {name2,-9} │ {author2,-9} │ ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{a2,-12} │ ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"{g2,-6} │");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"│ {name3,-9} │ {author3,-9} │ {a3,-12} │ {g3,-6} │");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("└───────────┴───────────┴──────────────┴────────┘");
        Console.ResetColor();

        // Примітка
        Console.WriteLine("Примітка: Х – художня література; Н – навчальна література; С – довідкова література");
    }
}
