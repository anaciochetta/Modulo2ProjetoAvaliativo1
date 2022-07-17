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
        string plate = ReadPlate();
        string buyerCPF = ReadCPF();
        decimal salePrice = ReadSalePrice();

        SellVehicle(plate, buyerCPF, salePrice);
    }
    //método para chamar o método de venda e imprimir na tela mensagem de venda
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
    //método para imprimir o cabeçalho da página
    public static void InputHeader()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite as informações para realizar a venda:");
    }
    //métodos de input para realizar a venda
    public static string ReadPlate()
    {
        InputHeader();
        Console.SetCursorPosition(3, 4);
        Console.Write("Placa: ");
        string plate = Console.ReadLine();

        while (!ValidateInputPlate.Validate(plate))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa inválida!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 4);
            Console.Write("Placa: ");
            plate = Console.ReadLine();
        }
        return plate;
    }

    public static string ReadCPF()
    {
        InputHeader();
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("CPF do comprador: ");
        string buyerCPF = Console.ReadLine();

        while (!ValidateInputCPF.Validate(buyerCPF))
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("CPF inválidO!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("CPF do comprador: ");
            buyerCPF = Console.ReadLine();
        }
        return buyerCPF;
    }
    public static decimal ReadSalePrice()
    {
        InputHeader();
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("Preço de venda: ");
        decimal salePrice = decimal.Parse(Console.ReadLine());

        while (!ValidateInputPrice.Validate(salePrice))
        {
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            InputHeader();
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Preço de venda: ");
            salePrice = decimal.Parse(Console.ReadLine());
        }
        return salePrice;
    }
}