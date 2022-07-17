using DevCar.Repositories;
using DevCar.Screens;
using System.Text.RegularExpressions;

namespace DevCar.Validators;

public static class ValidateInputCPF
{
    public static void Validate(string buyerCPF)
    {
        if (!ValidateInput(buyerCPF))
        {
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("CPF inválidO!");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            SellVehicleScreen.InputCPF();
        }
    }
    private static bool ValidateInput(string buyerCPF)
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