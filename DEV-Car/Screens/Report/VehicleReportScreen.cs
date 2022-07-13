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
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carros disponíveis");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        FilterAvailableVehicles();

        Console.ReadKey();
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
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carros vendidos");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        FilterSoldVehicles();
        Console.ReadKey();
    }

    private static void FilterSoldVehicles()
    {
        foreach (var sold in VehicleRepositoryList.VehicleList)
        {
            if (sold.IsAvailable == false) { Console.WriteLine(sold.ListVehicleInfo()); }
        }
    }
}