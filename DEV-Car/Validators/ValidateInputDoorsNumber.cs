using DevCar.Repositories;
using DevCar.Screens.Create;

namespace DevCar.Validators;

public static class ValidateInputDoorsNumber
{
    public static void ValidateCar(int doorsNumber)
    {
        if (doorsNumber > 4 || doorsNumber < 2)
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Número de portas inválido!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateCarScreen.InputDoorsNumber();
        }
    }
    public static void ValidatePickup(int doorsNumber)
    {
        if (doorsNumber > 4 || doorsNumber < 2)
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Número de portas inválido!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreatePickupScreen.InputDoorsNumber();
        }
    }
}