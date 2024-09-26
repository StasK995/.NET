using System.Collections.Generic;

// Клас для представлення особи
public class Person
{
    // Властивість для зберігання імені особи
    public string Name { get; set; }

    // Список, що містить майно, яке належить цій особі
    public List<Property> properties;

    // Конструктор класу, який приймає ім'я особи
    public Person(string name)
    {
        Name = name; // Присвоюємо ім'я особи
        properties = new List<Property>(); // Ініціалізуємо список майна
    }

    // Метод для додавання майна до списку
    public void AddProperty(Property property)
    {
        properties.Add(property); // Додаємо майно до списку
        Console.WriteLine($"Додано майно: {property}"); // Виводимо підтвердження
    }

    // Метод для видалення майна зі списку
    public void RemoveProperty(Property property)
    {
        // Спробуємо видалити майно з списку
        if (properties.Remove(property))
        {
            Console.WriteLine($"Видалено майно: {property}"); // Виводимо підтвердження
        }
        else
        {
            Console.WriteLine($"Майно не знайдено: {property}"); // Виводимо повідомлення, якщо майно не знайдено
        }
    }

    // Метод для відображення майна особи
    public void ShowProperties()
    {
        Console.WriteLine($"{Name} має наступне майно:"); // Виводимо заголовок
        foreach (var property in properties) // Проходимося по списку майна
        {
            Console.WriteLine(property); // Виводимо інформацію про кожне майно
        }
    }
}
