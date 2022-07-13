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
        Console.WriteLine("1 - Carros disponíveis");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Carros vendidos");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Carro vendido com o maior preço");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Carro vendido com o menor preço");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                AvaibleList();
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

    private static void AvaibleList()
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carros disponíveis");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");


        Console.ReadKey();
    }

    private static void SoldList()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carros vendidos");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");


        Console.ReadKey();
    }

    private static void HigherPrice()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carro vendido com o maior preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        var higherPrice = "exemplo";

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

        var lowerPrice = "exeplo";

        Console.SetCursorPosition(3, 5);
        Console.WriteLine($"{lowerPrice}");


        Console.ReadKey();
    }
}