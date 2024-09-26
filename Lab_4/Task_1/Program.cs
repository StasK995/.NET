using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Train> trains = new List<Train>();

        // Додавання випадкових поїздів до списку
        Random rand = new Random();
        string[] destinations = { "Kyiv", "Lviv", "Odessa", "Kharkiv", "Dnipro" };

        for (int i = 0; i < 5; i++)
        {
            string destination = destinations[rand.Next(destinations.Length)];
            int trainNumber = rand.Next(100, 999);
            TimeSpan departureTime = new TimeSpan(rand.Next(0, 24), rand.Next(0, 60), 0);
            int commonSeats = rand.Next(0, 100);
            int compartmentSeats = rand.Next(0, 50);
            int reservedSeats = rand.Next(0, 50);

            trains.Add(new Train(destination, trainNumber, departureTime, commonSeats, compartmentSeats, reservedSeats));
        }

        // Вивід усіх поїздів
        Console.WriteLine("Всі:");
        foreach (var train in trains)
        {
            train.Show();
        }

        // Додавання нового поїзда
        Console.WriteLine("\nДодавання нового з номером 999");
        trains.Add(new Train("Zaporizhzhia", 999, new TimeSpan(14, 30, 0), 50, 30, 20));

        Console.WriteLine("Всі після додавання:");
        foreach (var train in trains)
        {
            train.Show();
        } 

        // Редагування існуючого поїзда
        Console.WriteLine("\nРедагування поїзда з номером 999...");
        foreach (var train in trains)
        {
            if (train.TrainNumber == 999)
            {
                train.Destination = "Odesa"; // Використовуємо властивість
                train.CommonSeats = 60; // Використовуємо властивість
            }
        }

        Console.WriteLine("Всі після редагування:");
        foreach (var train in trains)
        {
            train.Show();
        }

        // Видалення поїзда за критерієм (наприклад, поїзд до "Lviv")
        Console.WriteLine("\nВидалення поїздів до Lviv...");
        trains.RemoveAll(t => t.Destination == "Lviv"); // Використовуємо властивість

        // Вивід списку після редагування
        Console.WriteLine("\nОновлений список поїздів:");
        foreach (var train in trains)
        {
            train.Show();
        }

        // Фільтрація поїздів за пунктом призначення та наявністю спільних місць
        Console.WriteLine("\nВведіть пункт призначення для пошуку поїздів зі спільними місцями:");
        string searchDestination = Console.ReadLine();
        Console.WriteLine($"\nПоїзди до {searchDestination} зі спільними місцями:");
        foreach (var train in trains)
        {
            if (train.Destination == searchDestination && train.HasCommonSeats()) // Використовуємо властивість
                train.Show();
        }
    }
}
