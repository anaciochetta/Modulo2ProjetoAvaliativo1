using DevCar.Screens.Report;

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
                VehicleReportScreen.Init(true);
                break;
            case 2:
                VehicleReportScreen.Init(false);
                break;
            case 3:
                PriceReportScreen.Init(false);
                break;
            case 4:
                PriceReportScreen.Init(true);
                break;
            case 0:
                MenuScreen.Init();
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }




}