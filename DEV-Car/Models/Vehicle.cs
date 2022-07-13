namespace DevCar.Models;

public class Vehicle
{
    public Guid ChassisNumber { get; set; }
    public int FabricationYear { get; set; }
    public string Name { get; set; }
    public string Plate { get; set; }
    public decimal PurcharseValue { get; set; }
    public decimal SellValue { get; set; }
    public int BuyerCPF { get; set; }
    public string Color { get; set; }

    public Vehicle() { }
    public Vehicle(int fabricationYear, string name, string plate, decimal purcharseValue, decimal sellValue, string color)
    {
        ChassisNumber = Guid.NewGuid();
        FabricationYear = fabricationYear;
        Name = name;
        Plate = plate;
        PurcharseValue = purcharseValue;
        SellValue = sellValue;
        BuyerCPF = 0;
        Color = color;
    }

    public void SellVehicle() { }
    public string ListVehicleInfo()
    {
        return "";
    }
    public void ChangeColor() { }
    public void ChangeValue() { }

}