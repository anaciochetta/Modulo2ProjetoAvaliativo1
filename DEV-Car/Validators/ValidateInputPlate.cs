using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputPlate
{
    //verifica quando cria o veículo
    public static bool Validate(string plate)
    {
        //verifica se está vazio ou null
        if (string.IsNullOrWhiteSpace(plate)) { return false; }
        if (plate == "") { return false; }

        //verifica o tamanho da placa
        if (plate.Length > 8) { return false; }

        plate = plate.Replace("-", "").Trim();

        //verifica se o caractere da posição 4 é uma letra
        if (char.IsLetter(plate, 4))
        {
            // verifica se a placa está no formato do mercosul, se são três letras, um número, uma letra e dois números
            Regex mercosul = new("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
            if (mercosul.IsMatch(plate))
            { return false; }
            else { return true; }
        }
        else
        {
            //verifica se está no formato antigo,  se os 3 primeiros caracteres são letras e se os 4 últimos são números
            Regex regular = new("[a-zA-Z]{3}[0-9]{4}");
            if (regular.IsMatch(plate))
            { return true; }
            else { return false; }
        }
    }
}