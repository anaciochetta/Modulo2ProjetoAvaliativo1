using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;

namespace DevCar.Screens.Create;

class CreatePickupScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color)
    {
        CreatePickup(fabricationYear, vehicleName, plate, purchasePrice, color);
    }
    private static void CreatePickup(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color)
    {
        EFuel fuelType = (EFuel)FuelUtil.PrintPickupFuelOptions();
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 3);
        Console.Write($"Diesel ou gasolina: {fuelType}");
        Console.SetCursorPosition(3, 4);
        Console.Write("Total de portas: ");
        var doorsNumber = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 5);
        Console.Write("Potência (em cavalos): ");
        var horsepower = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 6);
        Console.Write("Capacidade de carregamento (litros): ");
        var capacity = decimal.Parse(Console.ReadLine());

        Pickup pickup = new(fabricationYear, vehicleName, plate, purchasePrice, color, doorsNumber, fuelType, horsepower, capacity);

        VehicleRepositoryList.VehicleList.Add(pickup);

        ShowPickupRegistered(pickup.FabricationYear, pickup.Name, pickup.Plate, pickup.ChassisNumber, pickup.PurchasePrice, pickup.Color, pickup.DoorsNumber, pickup.FuelType, pickup.Horsepower, pickup.PickupTruckCapacity);
    }
    //mostra camionete registrado na tela
    private static void ShowPickupRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, EColors color, int doorsNumber, EFuel fuelType, decimal horsepower, decimal pickupTruckCapacity)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Camionete cadastrada com sucesso!");

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
        Console.Write($"Quantidade de portas: {doorsNumber}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Combustivel: {fuelType}");
        Console.SetCursorPosition(3, 12);
        Console.WriteLine($"Potência: {horsepower} cavalos");
        Console.SetCursorPosition(3, 13);
        Console.WriteLine($"Capacidade da caçamba: {pickupTruckCapacity} litros");

        MenuUtils.ControlKey();
    }
}
