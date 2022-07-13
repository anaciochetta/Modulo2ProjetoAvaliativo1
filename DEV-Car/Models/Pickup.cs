namespace DevCar.Models;

class Pickup : Car
{
    public decimal PickupTruckCapacity { get; set; } //capacidade da caçamba

    public Pickup() { }
    public Pickup(decimal pickupTruckCapacity, int fabricationYear, string name, string plate, decimal purcharseValue, decimal sellValue, string color, int doorsNumber, string fuelType, decimal horsepower) : base(fabricationYear, name, plate, purcharseValue, sellValue, color, doorsNumber, fuelType, horsepower)
    {
        PickupTruckCapacity = pickupTruckCapacity;
    }
}