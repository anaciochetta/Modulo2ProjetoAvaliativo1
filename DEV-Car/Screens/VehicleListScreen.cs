using DevCar.Repositories;

namespace DevCar.Screens;

public static class VehicleListScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
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

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");


        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                ShowList("carro");
                break;
            case 2:
                ShowList("moto");
                break;
            case 3:
                ShowList("triciclo");
                break;

            case 4:
                ShowList("pickup");
                break;
            case 5:
                ShowList("todos");
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }

    private static void ShowList(string filter)
    {
        if (filter == "carro")
        {

        }
        else if (filter == "pickup")
        {

        }
        else if (filter == "moto")
        {

        }
        else if (filter == "triciclo")
        {

        }
        else if (filter == "todos")
        {
            Console.Clear();
            AllVehiclesList();
        }

        Console.ReadKey();
    }

    private static void AllVehiclesList()
    {
        foreach (var vehicle in VehicleRepositoryList.VehicleList)
        {
            Console.WriteLine(vehicle.ListVehicleInfo());
        }
    }
}