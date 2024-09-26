using System;

public class LuxuryBus : Bus
{
    public bool HasToilet { get; set; }
    public bool HasRecliningSeats { get; set; }

    public LuxuryBus(string destination, int busNumber, TimeSpan departureTime, int seats, bool hasWiFi, bool hasToilet, bool hasRecliningSeats)
        : base(destination, busNumber, departureTime, seats, hasWiFi)
    {
        HasToilet = hasToilet;
        HasRecliningSeats = hasRecliningSeats;
    }

    public void ServeDrinks() // Новий метод
    {
        Console.WriteLine("Напої подаються пасажирам...");
    }

    public void ProvideEntertainment() // Новий метод
    {
        Console.WriteLine("Пасажирам надаються розважальні програми...");
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Luxury ");
        Console.ResetColor();
        base.Show();
        Console.WriteLine($"Has Toilet: {(HasToilet ? "Yes" : "No")}, Has Reclining Seats: {(HasRecliningSeats ? "Yes" : "No")}");
    }
}
