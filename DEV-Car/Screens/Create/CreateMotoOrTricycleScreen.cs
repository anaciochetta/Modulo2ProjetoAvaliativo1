using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screens.Create;

class CreateMotoOrTricycleScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, decimal salePrice, string color, string vehicleType)
    {
        CreateMotoOrTricycle(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, vehicleType);
    }

    private static void CreateMotoOrTricycle(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, decimal salePrice, string color, string vehicleType)
    {
        Console.SetCursorPosition(3, 11);
        Console.Write("Potência (em cavalos): ");
        var horsepower = short.Parse(Console.ReadLine());

        if (vehicleType == "moto")
        {
            Motorcycle moto = new(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, horsepower);

            VehicleRepositoryList.VehicleList.Add(moto);

            ShowMotoOrTricycleRegistered(fabricationYear, vehicleName, plate, moto.ChassisNumber, purchasePrice, salePrice, color, moto.WheelNumber, horsepower);
        }
        else if (vehicleType == "tricycle")
        {
            Tricycle tricycle = new(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, horsepower);

            VehicleRepositoryList.VehicleList.Add(tricycle);

            ShowMotoOrTricycleRegistered(fabricationYear, vehicleName, plate, tricycle.ChassisNumber, purchasePrice, salePrice, color, tricycle.WheelNumber, horsepower);
        }
    }

    //mostra triciclo e moto registrado na tela
    private static void ShowMotoOrTricycleRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, decimal salePrice, string color, int wheelNumber, decimal horsepower)
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Camionete cadastrado com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de venda: {salePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Quantidade de rodas: {wheelNumber}");
        Console.SetCursorPosition(3, 12);
        Console.WriteLine($"Potência: {horsepower} cavalos");

        MenuScreen.ControlKey();
    }
}