namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Added: {item.TrackingNumber}");
    }

    public double GetTotalCost()
    {
        double result = 0;
        foreach (var item in _items)
        {
            result += item.CalculateCost();
        }
        return result;
    }
}