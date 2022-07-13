namespace DevCar.Models;

class Pickup : Car
{
    public decimal PickupTruckCapacity { get; set; } //capacidade da caçamba

    public Pickup() { }
    public Pickup(int fabricationYear, string name, string plate, decimal purchasePrice, decimal salePrice, string color, int doorsNumber, string fuelType, decimal horsepower, decimal pickupTruckCapacity) : base(fabricationYear, name, plate, purchasePrice, salePrice, color, doorsNumber, fuelType, horsepower)
    {
        PickupTruckCapacity = pickupTruckCapacity;
    }
}