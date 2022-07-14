namespace DevCar.Models;

class Motorcycle : Vehicle
{
    public int WheelNumber { get { return 2; } }
    public decimal Horsepower { get; set; }

    public Motorcycle(int fabricationYear, string name, string plate, decimal purcharseValue, EColors color, decimal horsepower) : base(fabricationYear, name, plate, purcharseValue, color)
    {
        Horsepower = horsepower;
    }
}