using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens;

public static class ModifyVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        SelecVehicleToModify();
    }

    //tela para colocar a placa do veículo para modificação
    private static void SelecVehicleToModify()
    {
        MenuScreen.PrintHorizontalLine();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite a placa do veículo para modificação:");

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
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa não encontrada!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Deseja tentar novamente? (S ou N)");
            Console.SetCursorPosition(3, 8);
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
                Console.WriteLine("Resposta Inválida, tente novamente!");
                ConfirmVehicle(plate);
            }
        }
        MenuScreen.PrintHorizontalLine();
    }

    //verifica se a placa existe no repositório
    private static bool CheckPlate(string plate)
    {
        var inventory = VehicleRepositoryList.VehicleList;
        if (inventory.Any(vehicle => vehicle.Plate == plate))
        {
            return true;
        }
        else return false;
    }

    //tela para confirmar o veículo selecionado
    private static void ConfirmVehicle(string plate)
    {
        Console.Clear();
        MenuScreen.PrintHorizontalLine();
        Console.WriteLine("Este é o veículo que deseja alterar?");
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        System.Console.WriteLine(vehicle.ListVehicleInfo());
        System.Console.WriteLine("");
        System.Console.WriteLine("Digite S para sim e N para não");
        var answer = Console.ReadLine();
        MenuScreen.PrintHorizontalLine();
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

    //tela e método para escolher a modificação a ser feita
    private static void SelectChangeScreen(string plate)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha a modificação desejada:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Cor");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Valor de compra");
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
                ChangePrice(plate);
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

        EColors color = (EColors)ColorsUtil.PrintColorsOptions();
        System.Console.WriteLine(color);

        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangeColor(color);
    }

    //TODO: separar o tipo de valor pra mudar
    private static void ChangePrice(string plate)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Modificar Valor: ");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Valor de compra: ");
        decimal salePrice = decimal.Parse(Console.ReadLine());
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangePurchasePrice(salePrice);
    }
    private static void DeleteVehicle(string plate)
    {
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        IList<Vehicle> repository = VehicleRepositoryList.VehicleList;
        repository.Remove(vehicle);
    }
}