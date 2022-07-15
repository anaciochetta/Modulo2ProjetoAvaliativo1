using DevCar.Repositories;
using DevCar.Screens.Create;

namespace DevCar.Validators;

public static class ValidateInputPlate
{
    public static void ValidatePlate(string plate)
    {
        if (VehicleRepositoryList.VerifyExistentPlate(plate))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa já existente!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'A' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputPlate();
        }
    }
}