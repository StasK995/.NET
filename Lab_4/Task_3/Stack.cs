using System;

public class Stack
{
    // Масив для зберігання елементів стека
    private int[] _elements;
    // Кількість елементів у стеку
    private int _size;
    // Максимальна місткість стека
    private int _capacity;

    // Конструктор за замовчуванням
    public Stack(int capacity = 10)
    {
        _capacity = capacity; // Ініціалізація максимального розміру стека
        _elements = new int[_capacity]; // Виділення пам'яті під масив
        _size = 0; // Ініціалізація кількості елементів
    }

    // Перевантажений оператор для додавання елемента в стек
    public static Stack Push(Stack stack, int value)
    {
        // Перевіряємо, чи стек переповнений
        if (stack._size >= stack._capacity)
        {
            // Якщо переповнений, збільшуємо його розмір
            stack.Resize();
        }
        // Додаємо новий елемент у верхню частину стека і збільшуємо розмір
        stack._elements[stack._size++] = value;
        return stack; // Повертаємо оновлений стек
    }

    // Перевантажений оператор для видалення елемента зі стека
    public static Stack Pop(Stack stack)
    {
        // Перевіряємо, чи стек не пустий
        if (stack._size > 0)
        {
            // Зменшуємо розмір стека, видаляючи верхній елемент
            stack._size--;
        }
        return stack; // Повертаємо оновлений стек
    }

    // Метод для зміни розміру масиву
    private void Resize()
    {
        _capacity *= 2; // Подвоюємо місткість стека
        int[] newElements = new int[_capacity]; // Створюємо новий масив з новою місткістю
        // Копіюємо старі елементи в новий масив
        Array.Copy(_elements, newElements, _size);
        _elements = newElements; // Заміщуємо старий масив новим
    }

    // Метод для отримання значення верхнього елемента стека
    public int Peek()
    {
        // Перевіряємо, чи стек не пустий
        if (_size > 0)
            return _elements[_size - 1]; // Повертаємо верхній елемент
        // Якщо стек пустий, викидаємо виключення
        throw new InvalidOperationException("Stack is empty.");
    }

    // Метод для видалення елементів за заданими індексами
    public void RemoveElements(int[] indices)
    {
        // Проходимо по масиву індексів, які потрібно видалити
        for (int i = 0; i < indices.Length; i++)
        {
            // Перевіряємо, чи індекс дійсний
            if (indices[i] < _size && indices[i] >= 0)
            {
                // Зсув елементів для видалення
                for (int j = indices[i]; j < _size - 1; j++)
                {
                    // Копіюємо наступний елемент на позицію поточного
                    _elements[j] = _elements[j + 1];
                }
                // Зменшуємо кількість елементів у стека
                _size--;
            }
        }
    }

    // Метод для виводу елементів стека в консоль
    public void PrintStack()
    {
        Console.WriteLine("Stack elements:");
        // Проходимо по всім елементам стека
        for (int i = 0; i < _size; i++)
        {
            // Виводимо кожен елемент
            Console.WriteLine(_elements[i]);
        }
    }

    public bool IsEmpty()
    {
        return _size == 0;
    }


}
