using DevCar.Screens.Create;

namespace DevCar.Validators;

public static class ValidateInputHorsepower
{
    public static void Validate(decimal horsepower)
    {
        if (!ValidateInput(horsepower))
        {
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputHorsepower();
        }
    }
    private static bool ValidateInput(decimal horsepower)
    {
        if (horsepower == 0) { return false; }
        else if (horsepower > 1600) { return false; } //número máximo de cavalos que achei num veículo
        else if (horsepower < 0) { return false; }
        else return true;
    }
}