using DevCar.Utils;
using DevCar.Screens.Create;
using DevCar.Screens.Report;
using DevCar.Screens.Modify;

namespace DevCar.Screens;

public class MenuScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        ShowOptions();
    }

    //tela e método do menu principal
    private static void ShowOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Seja bem vindo ao DevCar");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        Console.SetCursorPosition(3, 5);
        Console.WriteLine("1 - Cadastrar veículo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("2 - Modificar veículo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("3 - Vender veículo");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("4 - Listas de veículos");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("5 - Relátorios");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                CreateVehicleScreen.Init();
                break;
            case 2:
                SelectVehicleToModify.Init();
                break;
            case 3:
                SellVehicleScreen.Init();
                break;
            case 4:
                ListVehicleScreen.Init();
                break;
            case 5:
                ReportScreen.Init();
                break;
            case 0:
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }


}
