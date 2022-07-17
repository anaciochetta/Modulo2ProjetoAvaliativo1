using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputCPF
{
    public static bool Validate(string buyerCPF)
    {
        //verifica se está vazio ou null
        if (string.IsNullOrWhiteSpace(buyerCPF)) { return false; }
        if (buyerCPF == "") { return false; }

        //verifica o tamanho do cpf
        if (buyerCPF.Length > 14) { return false; }
        if (buyerCPF.Length < 11) { return false; }

        //verifica o formato inserido
        buyerCPF = buyerCPF.Replace("-", "").Trim();
        buyerCPF = buyerCPF.Replace(".", "").Trim();
        Regex cpf = new("[0-9]{11}");
        if (cpf.IsMatch(buyerCPF))
        { return true; }
        else { return false; }
    }
}