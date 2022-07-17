using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;
using DevCar.Validators;

namespace DevCar.Screens.Create;

class CreatePickupScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower)
    {
        CreatePickup(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);
    }
    private static void CreatePickup(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower)
    {
        EFuel fuelType = (EFuel)FuelUtil.PrintPickupFuelOptions(); //chama tela para listar os tipos de combustível
        CreateVehicleScreen.InputHeader();
        Console.SetCursorPosition(3, 5);
        Console.Write($"Diesel ou gasolina: {fuelType}");
        int doorsNumber = InputDoorsNumber();
        decimal capacity = InputCapacity();

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
    //métodos de input para cadastro
    public static int InputDoorsNumber()
    {
        Console.SetCursorPosition(3, 6);
        Console.Write("Total de portas: ");
        int doorsNumber = int.Parse(Console.ReadLine());
        ValidateInputDoorsNumber.ValidatePickup(doorsNumber);
        return doorsNumber;
    }
    public static decimal InputCapacity()
    {
        Console.SetCursorPosition(3, 7);
        Console.Write("Capacidade de carregamento (litros): ");
        decimal capacity = decimal.Parse(Console.ReadLine());
        ValidateInputCapacity.Validate(capacity);
        return capacity;
    }
}
