using System;

// Клас Train, що наслідується від Transport
public class Train : Transport
{
    // Реалізація властивостей
    public override string Destination { get; set; }
    public override int TrainNumber { get; set; }
    public override TimeSpan DepartureTime { get; set; }
    public int CommonSeats { get; set; }
    public int CompartmentSeats { get; set; }
    public int ReservedSeats { get; set; }

    // Конструктор
    public Train(string destination, int trainNumber, TimeSpan departureTime, int commonSeats, int compartmentSeats, int reservedSeats)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
        CommonSeats = commonSeats;
        CompartmentSeats = compartmentSeats;
        ReservedSeats = reservedSeats;
    }

    // Реалізація абстрактного методу
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Train - ");
        Console.ResetColor();
        Console.WriteLine($"Номер поїзда: {TrainNumber}, Пункт призначення: {Destination}, Час відправлення: {DepartureTime}, Спільні місця: {CommonSeats}, Купейні місця: {CompartmentSeats}, Плацкартні місця: {ReservedSeats}");
    }

    // Метод для перевірки наявності спільних місць
    public bool HasCommonSeats()
    {
        return CommonSeats > 0;
    }
}
