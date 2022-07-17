using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;
using DevCar.Validators;

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
        Console.Clear();
        EColors color = (EColors)ColorsUtil.PrintColorsOptions();
        Console.WriteLine(color);
        Console.Clear();
        MenuUtils.DrawCanvas();
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangeColor(color);
        ShowColorMessage(vehicle);
    }
    private static void ShowColorMessage(Vehicle vehicle)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.WriteLine("Cor modificada com sucesso!");
        Console.WriteLine("");
        Console.WriteLine(vehicle.ListVehicleInfo());
        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
    //método para mudar o preço de compra do veículo
    private static void ChangePrice(string plate)
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Modificar Valor");
        decimal salePrice = ReadPurchasePrice();
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.ChangePurchasePrice(salePrice);
        ShowPriceMessage(vehicle);
    }
    public static decimal ReadPurchasePrice()
    {
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Valor de compra: ");
        Console.SetCursorPosition(3, 5);
        decimal purchasePrice = decimal.Parse(Console.ReadLine());

        while (!ValidateInputPrice.Validate(purchasePrice))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Valor de compra: ");
            Console.SetCursorPosition(3, 5);
            purchasePrice = decimal.Parse(Console.ReadLine());
        }
        return purchasePrice;
    }
    private static void ShowPriceMessage(Vehicle vehicle)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.WriteLine("Preço modificado com sucesso!");
        System.Console.WriteLine("");
        Console.WriteLine(vehicle.ListVehicleInfo());

        MenuUtils.PrintHorizontalLine();
        MenuUtils.ControlKey();
    }
    //método para deletar veículo do repositório
    private static void DeleteVehicle(string plate)
    {
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        IList<Vehicle> repository = VehicleRepositoryList.VehicleList;
        repository.Remove(vehicle);
        MenuUtils.DrawSimpleCanvas();
        Console.WriteLine("Veículo removido com sucesso!");
        MenuUtils.ControlKey();
    }
}