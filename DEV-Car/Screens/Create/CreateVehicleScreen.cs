using DevCar.Utils;
using DevCar.Validators;

namespace DevCar.Screens.Create;

public class CreateVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        SelectVehicleTypeScreen();
    }
    //monta a tela para escolher o tipo do veículo
    private static void SelectVehicleTypeScreen()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha o tipo de veículo a ser criado:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Carro");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Moto");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Triciclo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Camionete");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("0 - Menu Principal");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                CreateVehicle("carro");
                break;
            case 2:
                CreateVehicle("moto");
                break;
            case 3:
                CreateVehicle("triciclo");
                break;
            case 4:
                CreateVehicle("pickup");
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }
    //monta a tela para criar o veículo e chama as funções de criação
    private static void CreateVehicle(string vehicleType)
    {
        InputHeader();
        string vehicleName = InputName();
        string plate = InputPlate();
        int fabricationYear = InputYearFabrication();
        decimal purchasePrice = InputPurchasePrice();
        decimal horsepower = InputHorsepower();
        Console.SetCursorPosition(3, 9);
        Console.Clear();
        EColors color = (EColors)ColorsUtil.PrintColorsOptions();
        Console.WriteLine(color);
        Console.Clear();

        if (vehicleType == "carro")
        {
            CreateCarScreen.Init(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);
        }
        else if (vehicleType == "pickup")
        {
            CreatePickupScreen.Init(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);
        }
        else if (vehicleType == "moto" || vehicleType == "triciclo")
        {
            CreateMotoOrTricycleScreen.Init(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower, vehicleType);
        }
    }
    public static void InputHeader()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Cadastro de veículo");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");
    }

    public static string InputName()
    {
        InputHeader();
        Console.SetCursorPosition(3, 4);
        Console.Write("Nome: ");
        string vehicleName = Console.ReadLine();
        ValidateInputName.Validate(vehicleName);
        return vehicleName;
    }
    public static string InputPlate()
    {
        InputHeader();
        Console.SetCursorPosition(3, 5);
        Console.Write("Placa: ");
        string plate = Console.ReadLine();
        ValidateInputPlate.ValidateCreate(plate);
        return plate;
    }
    public static int InputYearFabrication()
    {
        InputHeader();
        Console.SetCursorPosition(3, 6);
        Console.Write("Ano de fabricação: (ex: 2000)");
        int fabricationYear = int.Parse(Console.ReadLine());
        ValidateInputFabricationYear.Validate(fabricationYear);
        return fabricationYear;
    }

    public static decimal InputPurchasePrice()
    {
        InputHeader();
        Console.SetCursorPosition(3, 7);
        Console.Write("Valor de compra: ");
        decimal purchasePrice = decimal.Parse(Console.ReadLine());
        ValidateInputPrice.ValidatePurchasePrice(purchasePrice);
        return purchasePrice;
    }

    public static decimal InputHorsepower()
    {
        Console.SetCursorPosition(3, 8);
        Console.Write("Potência (em cavalos): ");
        decimal horsepower = decimal.Parse(Console.ReadLine());

        return horsepower;
    }
}
