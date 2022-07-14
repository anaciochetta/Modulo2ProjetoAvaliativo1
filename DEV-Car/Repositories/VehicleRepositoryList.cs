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

}