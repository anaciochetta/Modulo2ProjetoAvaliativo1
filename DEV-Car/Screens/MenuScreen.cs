namespace DevCar.Screens;

public class MenuScreen
{
    public static void Init()
    {
        Console.Clear();
        DrawCanvas();
        ShowOptions();

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                CreateVehicleScreen.Init();
                break;
            case 2:
                ModifyVehicleScreen.Init();
                break;
            case 3:
                DeleteVehicleScreen.Init();
                break;
            case 4:
                VehicleListScreen.Init();
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
        Console.WriteLine("3 - Excluir veículo");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("4 - Listas de veículos");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("5 - Relátorios");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");
    }
    public static void DrawCanvas()
    {
        PrintHorizontalLine();

        for (int line = 0; line <= 12; line++)
        {
            Console.Write("|");
            for (int i = 0; i <= 45; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
        }

        PrintHorizontalLine();
    }
    public static void PrintHorizontalLine()
    {
        Console.Write("+");
        for (int i = 0; i <= 45; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }
}
