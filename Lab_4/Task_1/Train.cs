using System;

public class Train
{
    // Властивості класу з автоматичними гетерами та сетерами
    public string Destination { get; set; }      // Пункт призначення
    public int TrainNumber { get; set; }         // Номер поїзда
    public TimeSpan DepartureTime { get; set; }  // Час відправлення
    public int CommonSeats { get; set; }         // Кількість спільних місць
    public int CompartmentSeats { get; set; }    // Кількість купейних місць
    public int ReservedSeats { get; set; }       // Кількість плацкартних місць

    // Конструктор за замовчуванням
    public Train() { }

    // Конструктор з параметрами
    public Train(string destination, int trainNumber, TimeSpan departureTime, int commonSeats, int compartmentSeats, int reservedSeats)
    {
        // Ініціалізація властивостей
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
        CommonSeats = commonSeats;
        CompartmentSeats = compartmentSeats;
        ReservedSeats = reservedSeats;
    }

    // Метод show для відображення інформації про поїзд
    public void Show()
    {
        Console.WriteLine($"\nTrain Number: {TrainNumber}, Destination: {Destination}, Departure Time: {DepartureTime}, Common Seats: {CommonSeats}, Compartment Seats: {CompartmentSeats}, Reserved Seats: {ReservedSeats}");
    }

    // Метод для перевірки наявності спільних місць
    public bool HasCommonSeats()
    {
        return CommonSeats > 0;
    }

    // Додатковий метод: Перевірка, чи поїзд відправляється після заданої години
    public bool DepartsAfter(TimeSpan time)
    {
        return DepartureTime > time;
    }
}
