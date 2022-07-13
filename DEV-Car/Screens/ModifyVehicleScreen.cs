namespace DevCar.Screens;

public static class ModifyVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        SelecVehicleToModify();
    }

    private static void SelecVehicleToModify()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escreva a placa do veículo para realizar a alteração:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Placa: ");
        string plate = Console.ReadLine();

        SelectChangeScreen(plate);

    }
    private static void SelectChangeScreen(string plate)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha a modificação desejada:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Cor");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Valor");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Cor e valor");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("0 - Voltar para o menu");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                ChangeColor(plate);
                break;
            case 2:
                ChangeValue(plate);
                break;
            case 3:
                ChangeBoth(plate);
                break;
            case 0:
                MenuScreen.Init();
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }

    private static void ChangeColor(string plate)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha a cor desejada:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Cor");
        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");
        Console.ReadLine();


    }
    private static void ChangeValue(string plate)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Modificar Valor: ");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Valor de compra: ");
        var salePrice = decimal.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Valor de venda: ");
        var purchasePrice = decimal.Parse(Console.ReadLine());
    }
    private static void ChangeBoth(string plate)
    {
        ChangeColor(plate);
        ChangeValue(plate);
    }


}