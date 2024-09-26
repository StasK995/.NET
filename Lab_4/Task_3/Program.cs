using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створюємо новий об'єкт стека
        Stack stack = new Stack();

        // Додаємо елементи до стека за допомогою перевантаженого оператора +
        stack += 1; // Додаємо 1
        stack += 2; // Додаємо 2
        stack += 3; // Додаємо 3
        stack += 4; // Додаємо 4
        stack += 5; // Додаємо 5

        // Виводимо вміст стека перед видаленням елементів
        Console.WriteLine("Стек:");
        stack.PrintStack(); // Викликаємо метод для виводу вмісту стека

        
        int[] indicesToRemove = { 1, 3 }; // Видалення 1-й (значення 2) і 3-й (значення 4) елеменів

        // Виклик метода для видалення елементів з заданими індексами
        stack.RemoveElements(indicesToRemove);

        // Вивід вміст стека після видалення елементів
        Console.WriteLine("Після видалення:");
        stack.PrintStack(); //  метод для виводу вмісту стека
    }
}
