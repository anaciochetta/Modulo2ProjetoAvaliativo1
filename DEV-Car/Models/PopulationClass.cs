using DevCar.Repositories;

namespace DevCar.Models;

public static class PopulationClass
{
    public static void Init()
    {
        var repository = VehicleRepositoryList.VehicleList;

        Car car1 = new(2008, "Palio", "ILT-1817", 20000, 13000, "Prata", 2, "Gasolina", 200);
        car1.IsAvailable = true;
        repository.Add(car1);

        var moto1 = new Motorcycle(2012, "Kavasaki", "ABC-123", 63000, 52123, "Verde", 500);
        moto1.IsAvailable = true;
        repository.Add(moto1);

        var tricycle1 = new Tricycle(2016, "Trycle Power", "ABC-153", 63000, 55555, "Verde", 500);
        tricycle1.IsAvailable = false;
        repository.Add(tricycle1);

        var pickup1 = new Pickup(2020, "Amarok", "CVB-963", 100000, 96753, "Preta", 2, "Diesel", 600, 800);
        pickup1.IsAvailable = true;
        repository.Add(pickup1);
    }
}