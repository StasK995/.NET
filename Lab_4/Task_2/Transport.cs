// Абстрактний базовий клас
public abstract class Transport
{
    // Абстрактні властивості
    public abstract string Destination { get; set; }
    public abstract int TrainNumber { get; set; }
    public abstract TimeSpan DepartureTime { get; set; }

    // Абстрактний метод
    public abstract void Show();

    // Конкретний метод
    public virtual bool DepartsAfter(TimeSpan time)
    {
        return DepartureTime > time;
    }
}
