// Клас для представлення майна
public class Property
{
    // Властивість для зберігання назви майна
    public string Name { get; set; }

    // Властивість для зберігання вартості майна
    public decimal Value { get; set; }

    // Конструктор класу, який приймає назву і вартість майна
    public Property(string name, decimal value)
    {
        Name = name; // Присвоюємо назву майна
        Value = value; // Присвоюємо вартість майна
    }

    // Перевизначення методу ToString() для отримання текстового представлення майна
    public override string ToString()
    {
        // Повертаємо рядок, що містить назву та вартість майна, відформатовану як валюта
        return $"{Name} (Вартість: {Value:C})";
    }
   
}
