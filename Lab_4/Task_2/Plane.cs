using System;

public class Plane : Transport
{
    // Реалізація абстрактних властивостей
    public override string Destination { get; set; }
    public override int TrainNumber { get; set; }
    public override TimeSpan DepartureTime { get; set; }

    public string Airline { get; set; } // Авіакомпанія
    public int FirstClassSeats { get; set; } // Кількість місць першого класу
    public int EconomyClassSeats { get; set; } // Кількість місць економ-класу

    public Plane(string destination, int flightNumber, TimeSpan departureTime, string airline, int firstClassSeats, int economyClassSeats)
    {
        Destination = destination;
        TrainNumber = flightNumber;
        DepartureTime = departureTime;
        Airline = airline;
        FirstClassSeats = firstClassSeats;
        EconomyClassSeats = economyClassSeats;
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Plane - ");
        Console.ResetColor();
        Console.WriteLine($"Flight Number: {TrainNumber}, Destination: {Destination}, Departure Time: {DepartureTime}, Airline: {Airline}, First Class Seats: {FirstClassSeats}, Economy Class Seats: {EconomyClassSeats}");
    }
}
