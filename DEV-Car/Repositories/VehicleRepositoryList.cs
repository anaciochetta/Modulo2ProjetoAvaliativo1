using DevCar.Models;

namespace DevCar.Repositories;

public static class VehicleRepositoryList
{
    public static IList<Vehicle> VehicleList { get; set; }

    static VehicleRepositoryList()
    {
        VehicleList = new List<Vehicle>();
    }
    public static void UpdateRepository() { }
    public static Vehicle? GetByPlate(string plate)
    { return VehicleList.Where(x => x.Plate == plate).FirstOrDefault(); }

    public static bool VerifyExistentPlate(string plate)
    {
        if (VehicleList.Any(vehicle => vehicle.Plate == plate))
        {
            return true;
        }
        else return false;
    }
}