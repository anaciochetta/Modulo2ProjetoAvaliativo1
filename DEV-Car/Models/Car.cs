namespace DevCar.Models;

class Car : Vehicle
{
    public int DoorsNumber { get; set; }
    public string FuelType { get; set; }
    public decimal Horsepower { get; set; }

    public Car() { }
    public Car(int fabricationYear, string name, string plate, decimal purchasePrice, EColors color, int doorsNumber, string fuelType, decimal horsepower) : base(fabricationYear, name, plate, purchasePrice, color)
    {
        DoorsNumber = doorsNumber;
        FuelType = fuelType;
        Horsepower = horsepower;
    }
    public override string ListVehicleInfo()
    {
        return $"{base.ListVehicleInfo()} | Combustível: {FuelType} | Potência {Horsepower}";
    }
}