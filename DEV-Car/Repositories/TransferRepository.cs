using DevCar.Models;

namespace DevCar.Repositories;

public static class TransferRepository
{
    public static IList<TransferVehicles> TransferData { get; set; }

    static TransferRepository()
    {
        TransferData = new List<TransferVehicles>();
    }

    public static TransferVehicles? HigherSalePrice()
    {
        decimal max = TransferData.Max(x => x.SalePrice);
        return TransferData.Where(x => x.SalePrice == max).FirstOrDefault();
    }

    public static TransferVehicles? LowerSalePrice()
    {
        decimal min = TransferData.Min(x => x.SalePrice);
        return TransferData.Where(x => x.SalePrice == min).FirstOrDefault();
    }

}