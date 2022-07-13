namespace DevCar.Models;

public class TransferVehicles
{
    public int VehicleData { get; set; }
    public string BuyerCPF { get; set; }
    public int SalePrice { get; set; }
    public DateTime Date { get; set; }

    public TransferVehicles() { }
}