namespace DevCar.Models;

class Pickup : Vehicle
{
    public decimal PickupTruckCapacity { get; set; } //capacidade da caçamba
    public int DoorsNumber { get; set; }
    public EFuel FuelType { get; set; }
    public decimal Horsepower { get; set; }

    public Pickup() { }
    public Pickup(int fabricationYear, string name, string plate, decimal purchasePrice, EColors color, int doorsNumber, EFuel fuelType, decimal horsepower, decimal pickupTruckCapacity) : base(fabricationYear, name, plate, purchasePrice, color)
    {
        PickupTruckCapacity = pickupTruckCapacity;
    }
    public override string ListVehicleInfo()
    {
        return $"{base.ListVehicleInfo()} | Combustível: {FuelType} | Potência {Horsepower}";
    }
}