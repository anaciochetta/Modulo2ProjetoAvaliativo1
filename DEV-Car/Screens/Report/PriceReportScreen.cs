namespace DevCar.Screens.Report;

public static class PriceReportScreen
{
    public static void Init(bool lowerPrice)
    {
        if (lowerPrice)
        {
            LowerPrice();
        }
        else if (!lowerPrice)
        {
            HigherPrice();
        }
    }
    private static void HigherPrice()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Veículo vendido com o maior preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        var higherPrice = FilterSalePrice(false);

        Console.SetCursorPosition(3, 5);
        Console.WriteLine($"{higherPrice}");
        MenuScreen.ControlKey();
    }

    private static void LowerPrice()
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Veículo vendido com o menor preço:");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        var lowerPrice = FilterSalePrice(true);

        Console.SetCursorPosition(3, 5);
        Console.WriteLine($"{lowerPrice}");
        MenuScreen.ControlKey();
    }

    // TODO: arrumar a lógica
    private static decimal FilterSalePrice(bool lowerPrice)
    {
        if (lowerPrice)
        {
            var price = 2;
            return price;
        }
        else if (!lowerPrice)
        {
            var price = 1;
            return price;
        }
        else { return 0; }
    }
}