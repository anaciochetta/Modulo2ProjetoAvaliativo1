using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;

namespace DevCar.Screens;

public static class SellVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        SelecVehicleToSell();
    }
    private static void SelecVehicleToSell()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite as informações para realizar a venda:");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Placa: ");
        string plate = Console.ReadLine();
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("CPF do comprador: ");
        string buyerCPF = Console.ReadLine();
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("Preço de venda: ");
        decimal salePrice = decimal.Parse(Console.ReadLine());

        SellVehicle(plate, buyerCPF, salePrice);
    }

    private static void SellVehicle(string plate, string buyerCPF, decimal salePrice)
    {
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        vehicle.SellVehicle(buyerCPF, salePrice);
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("Veículo vendido com sucesso!");
        Console.SetCursorPosition(3, 11);
        System.Console.WriteLine($"{vehicle.ListVehicleInfo()}");
        MenuUtils.ControlKey();
    }
}