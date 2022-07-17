using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;
using DevCar.Validators;

namespace DevCar.Screens.Create;

public static class CreateCarScreen
{
    public static void Init(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower)
    {
        CreateCar(fabricationYear, vehicleName, plate, purchasePrice, color, horsepower);
    }
    private static void CreateCar(int fabricationYear, string vehicleName, string plate, decimal purchasePrice, EColors color, decimal horsepower)
    {
        EFuel fuelType = (EFuel)FuelUtil.PrintCarFuelOptions(); //chama tela para listar os tipos de combustível
        CreateVehicleScreen.InputHeader();
        Console.SetCursorPosition(3, 5);
        Console.Write($"Flex ou somente gasolina: {fuelType}");
        int doorsNumber = InputDoorsNumber();

        Car car = new(fabricationYear, vehicleName, plate, purchasePrice, color, doorsNumber, fuelType, horsepower);

        ShowCarRegistered(car.FabricationYear, car.Name, car.Plate, car.ChassisNumber, car.PurchasePrice, car.Color, car.DoorsNumber, car.FuelType, car.Horsepower);

        VehicleRepositoryList.VehicleList.Add(car);
    }
    //mostra carro registrado na tela
    private static void ShowCarRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, EColors color, int doorsNumber, EFuel fuelType, decimal horsepower)
    {
        MenuUtils.DrawSimpleCanvas();
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
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Quantidade de portas: {doorsNumber}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Combustivel: {fuelType}");
        Console.SetCursorPosition(3, 12);
        Console.WriteLine($"Potência: {horsepower} cavalos");

        MenuUtils.ControlKey();
    }
    //método de input para cadastro
    public static int InputDoorsNumber()
    {
        CreateVehicleScreen.InputHeader();
        Console.SetCursorPosition(3, 6);
        Console.Write("Total de portas: ");
        int doorsNumber = int.Parse(Console.ReadLine());
        ValidateInputDoorsNumber.ValidateCar(doorsNumber);
        return doorsNumber;
    }
}