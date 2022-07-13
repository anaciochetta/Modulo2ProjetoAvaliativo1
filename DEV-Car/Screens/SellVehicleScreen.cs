using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screens;

public static class SellVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        SelecVehicleToSell();
    }

    private static void SelecVehicleToSell()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Insira as seguintes informações para realizar a venda:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Placa: ");
        string plate = Console.ReadLine();
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("CPF do comprador: ");
        string buyerCPF = Console.ReadLine();
    }

    private static void TransferVehicle()
    {
        TransferVehicles transferdVehicle = new();
        TransferRepository.TransferData.Add(transferdVehicle);
    }
}