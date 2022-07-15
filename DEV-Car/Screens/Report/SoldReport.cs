using DevCar.Repositories;
using DevCar.Utils;

namespace DevCar.Screens.Report;

public static class SoldReport
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.PrintHorizontalLine();
        SoldList();
    }
    private static void SoldList()
    {
        Console.WriteLine("Veículo vendidos");
        Console.WriteLine("");

        FilterSoldVehicles();

        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
    private static void FilterSoldVehicles()
    {
        foreach (var sold in VehicleRepositoryList.VehicleList)
        {
            if (sold.IsAvailable == false) { Console.WriteLine(sold.ListVehicleInfo()); }
        }
    }
}