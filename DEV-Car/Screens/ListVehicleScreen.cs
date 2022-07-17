using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens;

public static class ListVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        SelectListScreen();
    }
    private static void SelectListScreen()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha a lista a ser mostrada:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Carro");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Moto");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Triciclo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Camionete");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("5 - Todos");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Menu Principal");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                FilterandPrintByType<Car>();
                break;
            case 2:
                FilterandPrintByType<Motorcycle>();
                break;
            case 3:
                FilterandPrintByType<Tricycle>();
                break;
            case 4:
                FilterandPrintByType<Pickup>();
                break;
            case 5:
                AllVehiclesList();
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }
    //imprime no console uma lista com todos os veículos
    private static void AllVehiclesList()
    {
        MenuUtils.DrawSimpleCanvas();
        Console.WriteLine("Todos os veículos cadastrados: ");
        Console.WriteLine("");
        foreach (var vehicle in VehicleRepositoryList.VehicleList)
        {
            Console.WriteLine(vehicle.ListVehicleInfo());
            Console.WriteLine();
        }
        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
    //imprime no console uma lista com todos os veículos do tipo selecionado
    private static void FilterandPrintByType<T>() where T : Vehicle
    {
        MenuUtils.DrawSimpleCanvas();
        IList<Vehicle> repository = VehicleRepositoryList.VehicleList;
        var vehicles = repository.OfType<T>().ToList();
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.ListVehicleInfo());
            Console.WriteLine();
        }
        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
}