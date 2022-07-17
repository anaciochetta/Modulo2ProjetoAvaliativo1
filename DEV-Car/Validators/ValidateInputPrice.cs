using DevCar.Screens.Create;

namespace DevCar.Validators;

public static class ValidateInputPrice
{
    public static void ValidatePurchasePrice(decimal purchasePrice)
    {
        if (!Validate(purchasePrice))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputPurchasePrice();
        }
    }
    public static void ValidateSalePrice(decimal salePrice)
    {
        if (!Validate(salePrice))
        {
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Valor inválido!");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            CreateVehicleScreen.InputPurchasePrice();
        }
    }

    private static bool Validate(decimal price)
    {
        if (price == 0) { return false; }
        else if (price > 2000000) { return false; }
        else return true;
    }
}