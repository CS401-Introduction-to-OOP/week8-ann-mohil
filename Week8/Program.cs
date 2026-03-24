// See https://aka.ms/new-console-template for more information

namespace Week8;
class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("#A3224", 0.1);
        Letter letter2 = new Letter("#A3225", 0.3);
        Parcel parcel1 = new Parcel("#B4354", 0.5, "30x25x20");
        Parcel parcel2 = new Parcel("#B4355", 1.7, "45x30x25");
        
        letter1.PrintInfo();
        parcel2.PrintInfo();
        Console.WriteLine();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        double totalCost = myCargo.GetTotalCost();
        Console.WriteLine($"Загальна вартість доставки всіх елементів: {totalCost} грн");
        
    }
}