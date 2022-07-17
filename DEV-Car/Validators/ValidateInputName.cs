using DevCar.Screens.Create;
using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputName
{
    public static void Validate(string vehicleName)
    {
        if (!ValidateInput(vehicleName))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Nome inválido!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputName();
        }
    }
    private static bool ValidateInput(string vehicleName)
    {
        //verifica se está vazio ou null
        if (string.IsNullOrWhiteSpace(vehicleName)) { return false; }
        if (vehicleName == "") { return false; }

        //verifica o tamanho do nome
        if (vehicleName.Length > 20) { return false; }

        //verifica se é somente números
        Regex digit = new("[0-9]");
        if (digit.IsMatch(vehicleName))
        { return false; }
        else { return true; }
    }
}