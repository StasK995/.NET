using System;
using System.Collections.Generic;

public class Train
{
    // Поля класу
    private string destination;
    private string trainNumber;
    private DateTime departureTime;
    private int totalSeats;
    private int compartmentSeats;
    private int sleeperSeats;

    // Конструктор класу
    public Train(string destination, string trainNumber, DateTime departureTime, int totalSeats, int compartmentSeats, int sleeperSeats)
    {
        this.destination = destination;
        this.trainNumber = trainNumber;
        this.departureTime = departureTime;
        this.totalSeats = totalSeats;
        this.compartmentSeats = compartmentSeats;
        this.sleeperSeats = sleeperSeats;
    }

    public string Destination
    {
        get { return destination; }
        set { destination = value; }
    }

    public string TrainNumber
    {
        get { return trainNumber; }
        set { trainNumber = value; }
    }

    public DateTime DepartureTime
    {
        get { return departureTime; }
        set { departureTime = value; }
    }

    public int TotalSeats
    {
        get { return totalSeats; }
        set { totalSeats = value; }
    }

    public int CompartmentSeats
    {
        get { return compartmentSeats; }
        set { compartmentSeats = value; }
    }

    public int SleeperSeats
    {
        get { return sleeperSeats; }
        set { sleeperSeats = value; }
    }

    // Метод для виведення інформації про поїзд
    public void Show()
    {
        Console.WriteLine($"Номер поїзда: {trainNumber}");
        Console.WriteLine($"Пункт призначення: {destination}");
        Console.WriteLine($"Час відправлення: {departureTime}");
        Console.WriteLine($"Кількість місць: {totalSeats}");
        Console.WriteLine($"Купейні місця: {compartmentSeats}");
        Console.WriteLine($"Плацкартні місця: {sleeperSeats}");
        Console.WriteLine();
    }

    // Додатковий метод для перевірки наявності загальних місць
    public bool HasAvailableSeats()
    {
        bool hasSeats = totalSeats > 0;
        return hasSeats;
    }

    // Додатковий метод для перевірки часу відправлення
    public bool IsDepartureAfter(DateTime time)
    {
        return departureTime > time;
    }
}
