using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Створюємо список поліморфних об'єктів типу Transport
        List<Transport> transports = new List<Transport>();

        // Додаємо об'єкти різних класів
        transports.Add(new Train("Kyiv", 123, new TimeSpan(12, 30, 0), 100, 50, 20));
        transports.Add(new Plane("Lviv", 456, new TimeSpan(15, 45, 0), "Ukrainian Airlines", 12, 120));
        transports.Add(new Bus("Odesa", 789, new TimeSpan(10, 0, 0), 50, true));
        transports.Add(new LuxuryBus("Kharkiv-Lux", 321, new TimeSpan(14, 15, 0), 30, true, true, true));
        transports.Add(new ElectricBus("Chernivtsi-Electric", 654, new TimeSpan(9, 0, 0), 40, false, 100, 300));

        // Викликаємо метод Show для всіх об'єктів у списку
        foreach (Transport transport in transports)
        {
            transport.Show();
        }
    }
}
