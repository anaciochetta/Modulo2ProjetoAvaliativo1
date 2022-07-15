using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens.Report;

public static class HigherPriceReport
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        HigherPrice();
    }
    private static void HigherPrice()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Veículo vendido com o maior preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        TransferVehicles vehicle = TransferRepository.HigherSalePrice();

        Console.SetCursorPosition(3, 5);
        Console.WriteLine(vehicle.ToString());
        MenuUtils.ControlKey();
    }
}