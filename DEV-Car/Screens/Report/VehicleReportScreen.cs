using DevCar.Repositories;

namespace DevCar.Screens.Report;

public static class VehicleReportScreen
{
    public static void Init(bool available)
    {
        if (available)
        {
            AvailableList();
        }
        else if (!available)
        {
            SoldList();
        }
    }

    private static void AvailableList()
    {
        Console.Clear();
        MenuScreen.PrintHorizontalLine();
        Console.WriteLine("Veículo disponíveis");
        Console.WriteLine("---------------------------------");

        FilterAvailableVehicles();

        MenuScreen.PrintHorizontalLine();
        MenuScreen.ControlKey();
    }

    private static void FilterAvailableVehicles()
    {
        foreach (var availables in VehicleRepositoryList.VehicleList)
        {
            if (availables.IsAvailable == true) { Console.WriteLine(availables.ListVehicleInfo()); }
        }
    }
    private static void SoldList()
    {
        Console.Clear();
        MenuScreen.PrintHorizontalLine();
        Console.WriteLine("Veículo vendidos");

        FilterSoldVehicles();

        MenuScreen.PrintHorizontalLine();
        MenuScreen.ControlKey();
    }

    private static void FilterSoldVehicles()
    {
        foreach (var sold in VehicleRepositoryList.VehicleList)
        {
            if (sold.IsAvailable == false) { Console.WriteLine(sold.ListVehicleInfo()); }
        }
    }
}