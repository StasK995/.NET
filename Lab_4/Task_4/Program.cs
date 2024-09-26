using System;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Person person = new Person("Іван");
        Property house = new Property("Будинок", 150000);
        Property car = new Property("Автомобіль", 25000);

        person.AddProperty(house);
        person.AddProperty(car);

        person.ShowProperties();

        person.RemoveProperty(car);

        person.ShowProperties();
    }
}
