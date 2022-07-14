using DevCar.Repositories;

namespace DevCar.Models;

public class Vehicle
{
    public Guid ChassisNumber { get; set; }
    public int FabricationYear { get; set; }
    public string Name { get; set; }
    public string Plate { get; set; }
    public decimal PurchasePrice { get; private set; }
    public string BuyerCPF { get; set; }
    public EColors Color { get; private set; }
    public bool IsAvailable { get; set; }

    public Vehicle() { }
    public Vehicle(int fabricationYear, string name, string plate, decimal purchasePrice, EColors color)
    {
        ChassisNumber = Guid.NewGuid();
        FabricationYear = fabricationYear;
        Name = name;
        Plate = plate;
        PurchasePrice = purchasePrice;
        BuyerCPF = "0";
        Color = color;
        IsAvailable = true;
    }

    public void SellVehicle(string buyerCPF, decimal salePrice)
    {
        TransferVehicles tansfer = new TransferVehicles(this, buyerCPF, salePrice);

        TransferVehicles transferdVehicle = new();
        TransferRepository.TransferData.Add(transferdVehicle);

        this.BuyerCPF = buyerCPF;
    }

    //TODO: precisa colocar as coisas pra printar
    public virtual string ListVehicleInfo()
    {
        var text = $" Nome: {Name} | Placa: {Plate} | Ano de Fabricação: {FabricationYear}";
        return text;
    }
    public void ChangeColor(EColors color)
    {
        this.Color = color;
    }
    public void ChangePurchasePrice(decimal purchasePrice)
    {
        this.PurchasePrice = purchasePrice;
    }


}