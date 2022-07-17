using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputName
{
    public static bool Validate(string vehicleName)
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