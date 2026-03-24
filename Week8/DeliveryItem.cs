namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; }

    protected DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Delivery Item : {TrackingNumber} Weight : {Weight} kg");
    }
}