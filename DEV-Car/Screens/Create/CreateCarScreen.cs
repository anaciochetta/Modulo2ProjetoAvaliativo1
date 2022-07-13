using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screens.Create;

public static class CreateCarScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, decimal salePrice, string color)
    {
        CreateCar(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color);
    }
    private static void CreateCar(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, decimal salePrice, string color)
    {
        Console.SetCursorPosition(3, 10);
        Console.Write("Total de portas: ");
        var doorsNumber = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 11);
        Console.Write("Flex ou somente gasolina: ");
        string fuelType = Console.ReadLine();
        Console.SetCursorPosition(3, 12);
        Console.Write("Potência (em cavalos): ");
        var horsepower = short.Parse(Console.ReadLine());

        Car car = new(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, doorsNumber, fuelType, horsepower);

        ShowCarRegistered(car.FabricationYear, car.Name, car.Plate, car.ChassisNumber, car.PurchasePrice, car.SalePrice, car.Color, car.DoorsNumber, car.FuelType, car.Horsepower);

        VehicleRepositoryList.VehicleList.Add(car);
    }

    //mostra carro registrado na tela
    private static void ShowCarRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, decimal salePrice, string color, int doorsNumber, string fuelType, decimal horsepower)
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carro cadastrado com sucesso!");

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
        Console.Write($"Quantidade de portas: {doorsNumber}");
        Console.SetCursorPosition(3, 12);
        Console.Write($"Combustivel: {fuelType}");
        Console.SetCursorPosition(3, 13);
        Console.WriteLine($"Potência: {horsepower} cavalos");
    }
}