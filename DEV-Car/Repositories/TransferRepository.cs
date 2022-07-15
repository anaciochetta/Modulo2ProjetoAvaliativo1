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
        var max = TransferData.Max(x => x.SalePrice);
        return TransferData.Where(x => x.SalePrice == max).FirstOrDefault(); ;
    }

}