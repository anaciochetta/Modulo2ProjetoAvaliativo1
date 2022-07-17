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
    //método de venda dos veículos
    public void SellVehicle(string buyerCPF, decimal salePrice)
    {
        TransferVehicles transferdVehicle = new(this, buyerCPF, salePrice);
        TransferRepository.TransferData.Add(transferdVehicle);
        this.BuyerCPF = buyerCPF;
        this.IsAvailable = false;
    }
    //método para listar as informações dos veículos na tela
    public virtual string ListVehicleInfo()
    {
        var text = $" Nome: {Name} | Placa: {Plate} | Ano de Fabricação: {FabricationYear} | Cor {Color} \n| Preço de compra: {PurchasePrice}";
        return text;
    }
    //método para mudar a cor do veículo
    public void ChangeColor(EColors color)
    {
        this.Color = color;
    }
    //método para mudar o preço de compra do veículo
    public void ChangePurchasePrice(decimal purchasePrice)
    {
        this.PurchasePrice = purchasePrice;
    }
}