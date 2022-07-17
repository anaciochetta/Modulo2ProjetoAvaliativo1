namespace DevCar.Validators;

public static class ValidateInputHorsepower
{
    public static bool Validate(decimal horsepower)
    {
        if (horsepower == 0) { return false; }
        else if (horsepower > 1600) { return false; } //número máximo de cavalos que achei num veículo
        else if (horsepower < 0) { return false; }
        else return true;
    }
}