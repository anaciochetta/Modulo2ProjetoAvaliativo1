using DevCar.Utils;
using DevCar.Validators;
using DevCar.Repositories;
using System.Text.RegularExpressions;

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
        string vehicleName = ReadName();
        string plate = ReadPlate();
        int fabricationYear = ReadYearFabrication();
        decimal purchasePrice = ReadPurchasePrice();
        decimal horsepower = ReadHorsepower();
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
            CreatePickupScreen.Init(fabricationYear, vehicleName, plate, purchasePrice, EColors.Roxo, horsepower);
        }
        else if (vehicleType == "moto" || vehicleType == "triciclo")
        {
            CreateMotoOrTricycleScreen.Init(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower, vehicleType);
        }
    }
    //método para imprimir o cabeçalho da página
    public static void InputHeader()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Cadastro de veículo");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");
    }
    //métodos de input para cadastro
    public static string ReadName()
    {
        InputHeader();
        Console.SetCursorPosition(3, 4);
        Console.Write("Nome: ");
        string vehicleName = Console.ReadLine();

        while (!ValidateInputName.Validate(vehicleName))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Nome inválido!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 4);
            Console.Write("Nome: ");
            vehicleName = Console.ReadLine();
        }
        return vehicleName;
    }
    public static string ReadPlate()
    {
        InputHeader();
        Console.SetCursorPosition(3, 5);
        Console.Write("Placa: ");
        string plate = Console.ReadLine().ToUpper();

        while (VehicleRepositoryList.VerifyExistentPlate(plate))
        {
            //verifica se a placa já existe no repositório
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa já existente!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 5);
            Console.Write("Placa: ");
            plate = Console.ReadLine().ToUpper();
        }
        while (!ValidateInputPlate.Validate(plate))
        {
            //verifica os inputs possíveis
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa inválida!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            InputHeader();
            Console.SetCursorPosition(3, 5);
            Console.Write("Placa: ");
            plate = Console.ReadLine().ToUpper();
        }
        return plate;
    }
    public static int ReadYearFabrication()
    {
        InputHeader();
        Console.SetCursorPosition(3, 6);
        Console.Write("Ano de fabricação (ex: 2000):");
        int fabricationYear = int.Parse(Console.ReadLine());
        Regex year = new("[12]{1}[90]{1}[0-9]{2}");
        while (!year.IsMatch(fabricationYear.ToString()))
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Ano de fabricação inválido!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 6);
            Console.Write("Ano de fabricação (ex: 2000):");
            fabricationYear = int.Parse(Console.ReadLine());
        }
        return fabricationYear;
    }

    public static decimal ReadPurchasePrice()
    {
        InputHeader();
        Console.SetCursorPosition(3, 7);
        Console.Write("Valor de compra: ");
        decimal purchasePrice = decimal.Parse(Console.ReadLine());

        while (!ValidateInputPrice.Validate(purchasePrice))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 7);
            Console.Write("Valor de compra: ");
            purchasePrice = decimal.Parse(Console.ReadLine());
        }
        return purchasePrice;
    }

    public static decimal ReadHorsepower()
    {
        Console.SetCursorPosition(3, 8);
        Console.Write("Potência (em cavalos): ");
        decimal horsepower = decimal.Parse(Console.ReadLine());

        while (!ValidateInputHorsepower.Validate(horsepower))
        {
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            Console.SetCursorPosition(3, 8);
            Console.Write("Potência (em cavalos): ");
            horsepower = decimal.Parse(Console.ReadLine());
        }
        return horsepower;
    }
}
