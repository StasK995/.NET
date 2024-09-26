using System;

public class Bus : Transport
{
    // Реалізація абстрактних властивостей
    public override string Destination { get; set; }
    public override int TrainNumber { get; set; }
    public override TimeSpan DepartureTime { get; set; }

    public int Seats { get; set; } // Кількість місць в автобусі
    public bool HasWiFi { get; set; } // Наявність WiFi

    public Bus(string destination, int busNumber, TimeSpan departureTime, int seats, bool hasWiFi)
    {
        Destination = destination;
        TrainNumber = busNumber;
        DepartureTime = departureTime;
        Seats = seats;
        HasWiFi = hasWiFi;
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Bus - ");
        Console.ResetColor();
        Console.WriteLine($"Bus Number: {TrainNumber}, Destination: {Destination}, Departure Time: {DepartureTime}, Seats: {Seats}, WiFi: {(HasWiFi ? "Yes" : "No")}");
    }
}
