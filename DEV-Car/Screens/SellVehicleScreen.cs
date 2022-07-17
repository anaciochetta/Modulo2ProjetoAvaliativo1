using DevCar.Models;
using DevCar.Repositories;
using DevCar.Utils;
using DevCar.Validators;

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
        InputHeader();
        string plate = InputPlate();
        string buyerCPF = InputCPF();
        decimal salePrice = InputSalePrice();

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

    public static void InputHeader()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite as informações para realizar a venda:");
    }
    public static string InputPlate()
    {
        InputHeader();
        Console.SetCursorPosition(3, 4);
        Console.Write("Placa: ");
        string plate = Console.ReadLine();
        ValidateInputPlate.Validate(plate);
        return plate;
    }

    public static string InputCPF()
    {
        InputHeader();
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("CPF do comprador: ");
        string buyerCPF = Console.ReadLine();
        ValidateInputCPF.Validate(buyerCPF);
        return buyerCPF;
    }
    public static decimal InputSalePrice()
    {
        InputHeader();
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("Preço de venda: ");
        decimal salePrice = decimal.Parse(Console.ReadLine());
        ValidateInputPrice.ValidateSalePrice(salePrice);
        return salePrice;
    }
}