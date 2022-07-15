using DevCar.Repositories;
using DevCar.Utils;

namespace DevCar.Screens.Report;

public static class AvailableReport
{
    public static void Init()
    {
        Console.Clear();
        AvailableList();
    }
    private static void AvailableList()
    {
        MenuUtils.PrintHorizontalLine();
        Console.WriteLine("Veículo disponíveis");
        Console.WriteLine("");

        FilterAvailableVehicles();

        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
    private static void FilterAvailableVehicles()
    {
        foreach (var availables in VehicleRepositoryList.VehicleList)
        {
            if (availables.IsAvailable == true) { Console.WriteLine(availables.ListVehicleInfo()); }
        }
    }
}