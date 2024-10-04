using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створюємо новий об'єкт стека
        Stack stack = new Stack();

        // Додаємо 10 елементів до стека за допомогою методу Push
        stack = Stack.Push(stack, 1); // Додаємо 1
        stack = Stack.Push(stack, 2); // Додаємо 2
        stack = Stack.Push(stack, 3); // Додаємо 3
        stack = Stack.Push(stack, 4); // Додаємо 4
        stack = Stack.Push(stack, 5); // Додаємо 5
        stack = Stack.Push(stack, 6); // Додаємо 6
        stack = Stack.Push(stack, 7); // Додаємо 7
        stack = Stack.Push(stack, 8); // Додаємо 8
        stack = Stack.Push(stack, 9); // Додаємо 9
        stack = Stack.Push(stack, 10); // Додаємо 10

        // Виводимо вміст стека перед видаленням елементів
        Console.WriteLine("Стек:");
        stack.PrintStack(); // Викликаємо метод для виводу вмісту стека

        // Викликаємо метод Peek для отримання верхнього елемента
        Console.WriteLine($"Верхній елемент: {stack.Peek()}");

        // Видаляємо верхній елемент 3 рази
        stack = Stack.Pop(stack); // Видалення 1-го верхнього елемента
        Console.WriteLine("Після видалення верхнього елемента:");
        stack.PrintStack(); // Виводимо вміст стека

        stack = Stack.Pop(stack); // Видалення 2-го верхнього елемента
        Console.WriteLine("Після видалення ще одного верхнього елемента:");
        stack.PrintStack(); // Виводимо вміст стека

        stack = Stack.Pop(stack); // Видалення 3-го верхнього елемента
        Console.WriteLine("Після видалення ще одного верхнього елемента:");
        stack.PrintStack(); // Виводимо вміст стека

        // Викликаємо метод Peek для отримання нового верхнього елемента
        Console.WriteLine($"Нинішній верхній елемент: {stack.Peek()}");

        // Додаткове видалення елементів
        stack.RemoveElements(new int[] { 2, 0 }); // Видаляємо елементи за індексами 0 та 2
        Console.WriteLine("Після видалення елементів за індексами 2 та 0:");
        stack.PrintStack(); // Виводимо вміст стека
    }
}
