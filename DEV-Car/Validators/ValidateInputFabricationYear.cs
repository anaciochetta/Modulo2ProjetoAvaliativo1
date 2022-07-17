using DevCar.Screens.Create;
using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputFabricationYear
{
    public static void Validate(int fabricationYear)
    {
        Regex year = new("[12]{1}[0-9]{3}");
        if (!year.IsMatch(fabricationYear.ToString()))
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Ano de fabricação inválido!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputYearFabrication();
        }
    }
}