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
    //método para imprimir na tela os veículos vendidos
    private static void FilterSoldVehicles()
    {
        foreach (var sold in TransferRepository.TransferData)
        {
            Console.WriteLine(sold.ToString());
            Console.WriteLine("");
        }
    }
}