namespace DevCar.Models;

class Tricycle : Vehicle
{
    public int WheelNumber { get { return 3; } }
    public decimal Horsepower { get; set; }

    public Tricycle(int fabricationYear, string name, string plate, decimal purcharseValue, EColors color, decimal horsepower) : base(fabricationYear, name, plate, purcharseValue, color)
    {
        Horsepower = horsepower;
    }
    public override string ListVehicleInfo()
    {
        return $"{base.ListVehicleInfo()} | Potência {Horsepower}";
    }
}