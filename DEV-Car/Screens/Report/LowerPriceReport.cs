using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens.Report;

public static class LowerPriceReport
{
    public static void Init()
    {
        Console.Clear();
        LowerPrice();
    }
    private static void LowerPrice()
    {
        MenuUtils.PrintHorizontalLine();
        Console.WriteLine("Veículo vendido com o menor preço:");
        Console.WriteLine("---------------------------------");

        TransferVehicles vehicle = TransferRepository.LowerSalePrice();

        Console.WriteLine(vehicle.ToString());
        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
}