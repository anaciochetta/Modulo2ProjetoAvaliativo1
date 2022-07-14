using DevCar.Repositories;

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
        Console.SetCursorPosition(3, 5);
        string plate = Console.ReadLine();

        if (CheckPlate(plate))
        {
            ConfirmVehicle(plate);
        }
        else
        {
            System.Console.WriteLine("Placa não encontrada, deseja tentar novamente?");
            var answer = Console.ReadLine();
            if (answer == "S" || answer == "s")
            {
                Console.Clear();
                SelecVehicleToModify();
            }
            else if (answer == "N" || answer == "n")
            {
                Console.Clear();
                MenuScreen.Init();
            }
            else
            {
                System.Console.WriteLine("Resposta Inválida, tente novamente!");
                ConfirmVehicle(plate);
            }
        }
    }

    private static bool CheckPlate(string plate)
    {
        var inventory = VehicleRepositoryList.VehicleList;
        if (inventory.Any(vehicle => vehicle.Plate == plate))
        {
            return true;
        }
        else return false;
    }

    private static void ConfirmVehicle(string plate)
    {
        Console.Clear();
        System.Console.WriteLine("Este é o veículo que deseja alterar?");
        foreach (var vehicle in VehicleRepositoryList.VehicleList)
        {
            if (vehicle.Plate == plate) { Console.WriteLine(vehicle.ListVehicleInfo()); }
        }
        System.Console.WriteLine("Digite S para sim e N para não");
        var answer = Console.ReadLine();
        if (answer == "S" || answer == "s")
        {
            SelectChangeScreen(plate);
        }
        else if (answer == "N" || answer == "n")
        {
            SelecVehicleToModify();
        }
        else
        {
            System.Console.WriteLine("Resposta Inválida, tente novamente!");
            ConfirmVehicle(plate);
        }
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
        Console.WriteLine("3 - Exlcuir veículo");
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
                DeleteVehicle(plate);
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
    private static void DeleteVehicle(string plate)
    {

    }
}