namespace DevCar.Models;

public class Vehicle
{
    public Guid ChassisNumber { get; set; }
    public int FabricationYear { get; set; }
    public string Name { get; set; }
    public string Plate { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int BuyerCPF { get; set; }
    public string Color { get; set; }

    public Vehicle() { }
    public Vehicle(int fabricationYear, string name, string plate, decimal purchasePrice, decimal salePrice, string color)
    {
        ChassisNumber = Guid.NewGuid();
        FabricationYear = fabricationYear;
        Name = name;
        Plate = plate;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
        BuyerCPF = 0;
        Color = color;
    }

    public void SellVehicle() { }
    public virtual string ListVehicleInfo()
    {
        return "";
    }
    public void ChangeColor() { }
    public void ChangeValue() { }

}