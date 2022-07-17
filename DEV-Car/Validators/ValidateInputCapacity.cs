using DevCar.Repositories;
using DevCar.Screens.Create;

namespace DevCar.Validators;

public static class ValidateInputCapacity
{
    public static void Validate(decimal capacity)
    {
        if (!ValidateInput(capacity))
        {
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Capacidade inválida!");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreatePickupScreen.InputCapacity();
        }
    }

    private static bool ValidateInput(decimal capacity)
    {
        if (capacity == 0) { return false; }
        else if (capacity > 1500) { return false; }//número máximo de litros que achei numa camionete
        else if (capacity < 0) { return false; }
        else return true;
    }
}