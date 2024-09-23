public class Program
{
    public static void Main(string[] args)
    {
        List<Train> trains = new List<Train>
        {                                          //рік місяць день час
            new Train("Київ", "123A", new DateTime(2024, 9, 20, 15, 30, 0), 100, 10, 40),
            new Train("Львів", "456B", new DateTime(2024, 9, 21, 18, 45, 0), 150, 20, 60),
            new Train("Одеса", "789C", new DateTime(2024, 9, 20, 10, 15, 0), 80, 15, 30)
        };

        // Введенняпункту призначення та часу
        Console.Write("Введіть пункт призначення: ");
        string destination = Console.ReadLine();

        Console.Write("Введіть час (формат HH:MM): ");
        TimeSpan timeSpan = TimeSpan.Parse(Console.ReadLine());
        DateTime time = new DateTime(1, 1, 1, timeSpan.Hours, timeSpan.Minutes, 0);

        // Виведення списку поїздів 
        Console.WriteLine($"\nПоїзди, що прямують до {destination}:");
        foreach (var train in trains)
        {
            if (train.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                train.Show();
            }
        }

        // Виведення списку поїздів за пунктом призначення та часом відправлення
        Console.WriteLine($"\nПоїзди, що прямують до {destination} і відправляються після {timeSpan}:");
        foreach (var train in trains)
        {
            if (train.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase) && train.IsDepartureAfter(time))
            {
                train.Show();
            }
        }

        // Виведення списку поїздів з наявними місцями
        Console.WriteLine($"\nПоїзди, що прямують до {destination} і мають доступні місця:");
        foreach (var train in trains)
        {
            if (train.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase) && train.HasAvailableSeats())
            {
                train.Show();
            }
        }
    }
}
