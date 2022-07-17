namespace DevCar.Validators;

public static class ValidateInputPrice
{
    public static bool Validate(decimal price)
    {
        if (price == 0) { return false; }
        else if (price > 2000000) { return false; } //valor máximo determinado para preço de veículo
        else if (price < 0) { return false; }
        else return true;
    }
}