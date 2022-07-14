using DevCar.Repositories;
using DevCar.Models;

namespace DevCar.Screens.Report;

class HigherPriceReport
{
    private static void HigherPrice()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Veículo vendido com o maior preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        IList<TransferVehicles> repository = TransferRepository.TransferData;
        //repository.OrderBy();
        //fazer uma função pra pegar o maior - tipo sort

        Console.SetCursorPosition(3, 5);
        //Console.WriteLine($"{sdhjks}");
        MenuScreen.ControlKey();
    }

}