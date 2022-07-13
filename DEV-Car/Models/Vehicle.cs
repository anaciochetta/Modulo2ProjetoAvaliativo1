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
    public bool IsAvailable { get; set; }

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
        IsAvailable = true;
    }

    public void SellVehicle() { }

    //TODO: precisa colocar as coisas pra printar
    public virtual string ListVehicleInfo()
    {
        var text = $" Nome: {Name} | Placa: {Plate} | Ano de Fabricação: {FabricationYear}";
        return text;
    }
    public void ChangeColor() { }
    public void ChangeValue() { }

}