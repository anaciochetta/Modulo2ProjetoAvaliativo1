namespace DevCar.Screens;

class DeleteVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        SelecVehicleToDelete();
    }
    //TODO:
    private static void SelecVehicleToDelete()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escreva a placa do veículo para excluir:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Placa: ");
        string plate = Console.ReadLine();

        Console.ReadLine();
    }
}