using DevCar.Models;

namespace DevCar.Repositories;

public static class TransferRepository
{
    public static IList<TransferVehicles> TransferData { get; set; }

    static TransferRepository()
    {
        TransferData = new List<TransferVehicles>();
    }
}