using DevCar.Repositories;

namespace DevCar.Screens;

class ReportScreen
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
        Console.WriteLine("Escolha o relatório a ser mostrado:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Veículos disponíveis");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Veículos vendidos");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Veículo vendido com o maior preço");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Veículo vendido com o menor preço");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                AvailableList();
                break;
            case 2:
                SoldList();
                break;
            case 3:
                HigherPrice();
                break;
            case 4:
                LowerPrice();
                break;
            case 0:
                MenuScreen.Init();
                break;
            default:
                MenuScreen.Init();
                break;
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

    private static void HigherPrice()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carro vendido com o maior preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        var higherPrice = FilterSalePrice(false);

        Console.SetCursorPosition(3, 5);
        Console.WriteLine($"{higherPrice}");
        Console.ReadKey();
    }

    private static void LowerPrice()
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carro vendido com o menor preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        var lowerPrice = FilterSalePrice(true);

        Console.SetCursorPosition(3, 5);
        Console.WriteLine($"{lowerPrice}");
        Console.ReadKey();
    }

    // TODO: arrumar a lógica
    private static decimal FilterSalePrice(bool lowerPrice)
    {
        if (lowerPrice)
        {
            var price = 2;
            return price;
        }
        else if (!lowerPrice)
        {
            var price = 1;
            return price;
        }
        else { return 0; }
    }
}