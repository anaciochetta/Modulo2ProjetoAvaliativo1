namespace DevCar.Models;

class Tricycle : Vehicle
{
    public int WheelNumber { get; set; }
    public decimal Horsepower { get; set; }

    public Tricycle(int wheelNumber)
    {
        WheelNumber = 3;
    }
    public Tricycle(int fabricationYear, string name, string plate, decimal purcharseValue, decimal sellValue, string color, int wheelNumber, decimal horsepower) : base(fabricationYear, name, plate, purcharseValue, sellValue, color)
    {
        WheelNumber = 3;
        Horsepower = horsepower;
    }
}