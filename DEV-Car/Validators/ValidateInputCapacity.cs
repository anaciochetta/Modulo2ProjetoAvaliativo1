namespace DevCar.Validators;

public static class ValidateInputCapacity
{
    public static bool Validate(decimal capacity)
    {
        if (capacity == 0) { return false; }
        else if (capacity > 1500) { return false; }//número máximo de litros que achei numa camionete
        else if (capacity < 0) { return false; }
        else return true;
    }
}