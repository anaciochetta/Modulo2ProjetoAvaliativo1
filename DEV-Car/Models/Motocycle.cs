namespace DevCar.Models;

class Motorcycle : Vehicle
{
    public int WheelNumber { get; set; }
    public decimal Horsepower { get; set; }

    public Motorcycle(int wheelNumber)
    {
        WheelNumber = 2;
    }
    public Motorcycle(int fabricationYear, string name, string plate, decimal purcharseValue, decimal sellValue, string color, decimal horsepower) : base(fabricationYear, name, plate, purcharseValue, sellValue, color)
    {
        WheelNumber = 3;
        Horsepower = horsepower;
    }
}