/* Розробити програму для введення фактичних даних з таблиці, 
 * представленої у виданому варіанті індивідуальних завдань (див. п. 6),
 * і для виведення на екран таблиці, подібної тій, 
 * яка знаходиться в індивідуальному завданні (включаючи заголовок і примітки).
 Сенкевіч	Потоп	1978	Х
Ландау	Механіка	1989	Н
Дойль	Сумчасті	1990	C*/
using System;
using System.Text;
class Programm
{ 
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        string name1,name2,name3;
        string author1,author2,author3;
        int a1,a2,a3;
        char g1,g2,g3;

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

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("|Каталог бібліотеки                             |");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("|   Назва   |   Автор   |  Рік випуску  | Група |");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"| {name1,-9} | {author1,-9} | {a1,-12} | {g1,-5} |");
        Console.WriteLine($"| {name2,-9} | {author2,-9} | {a2,-12} | {g2,-5} |");
        Console.WriteLine($"| {name3,-9} | {author3,-9} | {a3,-12} | {g3,-5} |");
        Console.WriteLine("----------------------------------------------");

       
        Console.WriteLine("Примітка: Х – художня література; Н – навчальна література; С – довідкова література");
    
       }
}