using DevCar.Repositories;
using DevCar.Models;

namespace DevCar.Utils;

public static class PopulationClass
{
    public static void Init()
    {
        //carros criados
        IList<Vehicle> repository = VehicleRepositoryList.VehicleList;

        Car car1 = new(2008, "Palio", "ILT-1817", 20000, EColors.Prata, 2, EFuel.Gasolina, 200);
        car1.IsAvailable = true;
        repository.Add(car1);

        Motorcycle moto1 = new(2012, "Kavasaki", "ABC-123", 63000, EColors.Vermelho, 500);
        moto1.IsAvailable = true;
        repository.Add(moto1);

        Tricycle tricycle1 = new(2016, "Chooper", "ABC-153", 63000, EColors.Vermelho, 500);
        tricycle1.IsAvailable = true;
        repository.Add(tricycle1);

        Pickup pickup1 = new(2020, "Amarok", "CVB-963", 100000, EColors.Roxo, 2, EFuel.Diesel, 600, 800);
        pickup1.IsAvailable = true;
        repository.Add(pickup1);

        //carros vendidos
        IList<TransferVehicles> sellCars = TransferRepository.TransferData;

        Car car2 = new(2008, "Car 2", "DFD-1817", 20000, EColors.Prata, 2, EFuel.Gasolina, 200);
        car2.IsAvailable = false;
        car2.SellVehicle("1254548548", 50000);
        repository.Add(car2);


        Motorcycle moto2 = new(2012, "Moto 2", "GHJ-123", 63000, EColors.Vermelho, 500);
        moto2.IsAvailable = false;
        repository.Add(moto2);
        moto2.SellVehicle("54858585", 20000);

        Tricycle tricycle2 = new(2016, "Trycle 2", "HJH-153", 63000, EColors.Vermelho, 500);
        tricycle2.IsAvailable = false;
        repository.Add(tricycle2);
        tricycle2.SellVehicle("523848", 40000);

        Pickup pickup2 = new(2020, "Pickup 2", "KPE-963", 100000, EColors.Preto, 2, EFuel.Diesel, 600, 800);
        pickup2.IsAvailable = false;
        repository.Add(pickup2);
        pickup2.SellVehicle("123456987", 90000);
    }
}