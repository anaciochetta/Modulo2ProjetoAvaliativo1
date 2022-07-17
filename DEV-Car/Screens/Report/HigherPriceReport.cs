using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens.Report;

public static class HigherPriceReport
{
    public static void Init()
    {
        Console.Clear();
        HigherPrice();
    }
    private static void HigherPrice()
    {
        MenuUtils.PrintHorizontalLine();
        Console.WriteLine("Veículo vendido com o maior preço:");
        Console.WriteLine("---------------------------------");

        TransferVehicles vehicle = TransferRepository.HigherSalePrice();

        Console.WriteLine(vehicle.ToString());
        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
}