using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;

namespace DevCar.Screens.Modify;

public static class ModifyVehicleScreen
{
    public static void Init(string plate)
    {
        SelectChangeScreen(plate);
    }
    //tela e método para escolher a modificação a ser feita
    private static void SelectChangeScreen(string plate)
    {
        Console.Clear();
        MenuUtils.DrawCanvas();

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
    //método para mudar a cor do veículo
    private static void ChangeColor(string plate)
    {
        EColors color = (EColors)ColorsUtil.PrintColorsOptions();
        System.Console.WriteLine(color);
        Console.Clear();
        MenuUtils.DrawCanvas();
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangeColor(color);
        MenuUtils.ControlKey();
    }
    //método para mudar o preço de compra do veículo
    private static void ChangePrice(string plate)
    {
        Console.Clear();
        MenuUtils.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Modificar Valor: ");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Valor de compra: ");
        decimal salePrice = decimal.Parse(Console.ReadLine());
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangePurchasePrice(salePrice);
        MenuUtils.ControlKey();
    }
    //método para deletar veículo do repositório
    private static void DeleteVehicle(string plate)
    {
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        IList<Vehicle> repository = VehicleRepositoryList.VehicleList;
        repository.Remove(vehicle);
        Console.WriteLine("Veículo removido com sucesso!");
        MenuUtils.ControlKey();
    }
}