namespace DevCar.Models;

public class TransferVehicles
{
    public Vehicle VehicleData { get; set; }
    public string BuyerCPF { get; set; }
    public decimal SalePrice { get; set; }
    public DateTime Date { get; set; }

    public TransferVehicles() { }

    public TransferVehicles(Vehicle vehicleData, string buyerCPF, decimal salePrice)
    {
        VehicleData = vehicleData;
        BuyerCPF = buyerCPF;
        SalePrice = salePrice;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Preço de venda: {SalePrice}| Data de venda: {Date} \n Dados do veículo: {VehicleData.ListVehicleInfo()}";
    }
}