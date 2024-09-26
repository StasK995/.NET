using System;

public class ElectricBus : Bus
{
    public int BatteryCapacity { get; set; } // Ємність батареї в кВт·год
    public int Range { get; set; } // Дальність поїздки на одному заряді в км

    public ElectricBus(string destination, int busNumber, TimeSpan departureTime, int seats, bool hasWiFi, int batteryCapacity, int range)
        : base(destination, busNumber, departureTime, seats, hasWiFi)
    {
        BatteryCapacity = batteryCapacity;
        Range = range;
    }

    public void ChargeBattery() // Новий метод
    {
        if (BatteryCapacity <= 0) // Перевірка на нульову ємність
        {
            Console.WriteLine("Не можна заряджати: ємність батареї дорівнює нулю.");
        }
        else
        {
            Console.WriteLine("Батарея заряджається...");
        }
    }

    public void DisplayRange() // Новий метод
    {
        Console.WriteLine($"Дальність поїздки на одному заряді: {Range} км.");
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Electric ");
        Console.ResetColor();
        base.Show();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh, Range: {Range} km");
    }
}
