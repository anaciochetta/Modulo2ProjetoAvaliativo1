using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;

namespace DevCar.Screens.Create;

class CreateMotoOrTricycleScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower, string vehicleType)
    {
        CreateMotoOrTricycle(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower, vehicleType);
    }
    private static void CreateMotoOrTricycle(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower, string vehicleType)
    {

        if (vehicleType == "moto")
        {
            Motorcycle moto = new(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);

            VehicleRepositoryList.VehicleList.Add(moto);

            ShowMotoRegistered(fabricationYear, vehicleName, plate, moto.ChassisNumber, purchasePrice, color, moto.WheelNumber, horsepower);
        }
        else if (vehicleType == "tricycle")
        {
            Tricycle tricycle = new(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);

            VehicleRepositoryList.VehicleList.Add(tricycle);

            ShowTricycleRegistered(fabricationYear, vehicleName, plate, tricycle.ChassisNumber, purchasePrice, color, tricycle.WheelNumber, horsepower);
        }
    }

    //mostra triciclo registrado na tela
    private static void ShowTricycleRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, EColors color, int wheelNumber, decimal horsepower)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Triciclo cadastrado com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Quantidade de rodas: {wheelNumber}");
        Console.SetCursorPosition(3, 11);
        Console.WriteLine($"Potência: {horsepower} cavalos");

        MenuUtils.ControlKey();
    }
    //mostra moto registrada na tela
    private static void ShowMotoRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, EColors color, int wheelNumber, decimal horsepower)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Moto cadastrada com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Quantidade de rodas: {wheelNumber}");
        Console.SetCursorPosition(3, 11);
        Console.WriteLine($"Potência: {horsepower} cavalos");

        MenuUtils.ControlKey();
    }
}