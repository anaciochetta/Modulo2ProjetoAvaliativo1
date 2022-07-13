using DevCar.Models;

namespace DevCar.Screens;

public class CreateVehicleScreen
{
    public static void Init()
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        SelectVehicleTypeScreen();
    }

    private static void SelectVehicleTypeScreen()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Escolha o tipo de veículo a ser criado:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Carro");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Moto");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Triciclo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Camionete");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");


        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                CreateVehicle("carro");
                break;
            case 2:
                CreateVehicle("moto");
                break;
            case 3:
                CreateVehicle("triciclo");
                break;
            case 4:
                CreateVehicle("pickup");
                break;
            default:
                MenuScreen.Init();
                break;
        }
    }

    private static void CreateVehicle(string vehicleType)
    {
        Console.Clear();
        MenuScreen.DrawCanvas();

        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Cadastro de veículo");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        Console.SetCursorPosition(3, 4);
        Console.Write("Nome: ");
        string vehicleName = Console.ReadLine();
        Console.SetCursorPosition(3, 5);
        Console.Write("Placa: ");
        string plate = Console.ReadLine();
        Console.SetCursorPosition(3, 6);
        Console.Write("Ano de fabricação: ");
        var fabricationYear = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 7);
        Console.Write("Valor de compra: ");
        var purchasePrice = decimal.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 8);
        Console.Write("Valor de venda: ");
        var salePrice = decimal.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 9);
        Console.Write("Cor: ");
        string color = Console.ReadLine();

        if (vehicleType == "carro")
        {
            Console.SetCursorPosition(3, 10);
            Console.Write("Total de portas: ");
            var doorsNumber = short.Parse(Console.ReadLine());
            Console.SetCursorPosition(3, 11);
            Console.Write("Flex ou somente gasolina: ");
            string fuelType = Console.ReadLine();
            Console.SetCursorPosition(3, 12);
            Console.Write("Potência (em cavalos): ");
            var horsepower = short.Parse(Console.ReadLine());

            Car car = new Car(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, doorsNumber, fuelType, horsepower);

            ShowCarRegistered(car.FabricationYear, car.Name, car.Plate, car.ChassisNumber, car.PurchasePrice, car.SalePrice, car.Color, car.DoorsNumber, car.FuelType, car.Horsepower);
        }
        else if (vehicleType == "pickup")
        {
            Console.SetCursorPosition(3, 10);
            Console.Write("Total de portas: ");
            var doorsNumber = short.Parse(Console.ReadLine());
            Console.SetCursorPosition(3, 11);
            Console.Write("Diesel ou gasolina: ");
            string fuelType = Console.ReadLine();
            Console.SetCursorPosition(3, 12);
            Console.Write("Potência (em cavalos): ");
            var horsepower = short.Parse(Console.ReadLine());
            Console.SetCursorPosition(3, 13);
            Console.Write("Capacidade de carregamento na caçamba (em litros): ");
            var capacity = decimal.Parse(Console.ReadLine());

            Pickup pickup = new Pickup(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, doorsNumber, fuelType, horsepower, capacity);

            ShowPickupRegistered(pickup.FabricationYear, pickup.Name, pickup.Plate, pickup.ChassisNumber, pickup.PurchasePrice, pickup.SalePrice, pickup.Color, pickup.DoorsNumber, pickup.FuelType, pickup.Horsepower, pickup.PickupTruckCapacity);
        }
        else if (vehicleType == "moto" || vehicleType == "triciclo")
        {
            /* Console.SetCursorPosition(3, 10);
            Console.Write("Total de rodas: ");
            var wheelNumber = short.Parse(Console.ReadLine()); */
            Console.SetCursorPosition(3, 11);
            Console.Write("Potência (em cavalos): ");
            var horsepower = short.Parse(Console.ReadLine());

            if (vehicleType == "moto")
            {
                Motorcycle moto = new Motorcycle(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, horsepower);

                ShowMotoOrTricycleRegistered(fabricationYear, vehicleName, plate, moto.ChassisNumber, purchasePrice, salePrice, color, moto.WheelNumber, horsepower);
            }
            else if (vehicleType == "tricycle")
            {
                Tricycle tricycle = new Tricycle(fabricationYear, vehicleName, plate, purchasePrice, salePrice, color, horsepower);

                ShowMotoOrTricycleRegistered(fabricationYear, vehicleName, plate, tricycle.ChassisNumber, purchasePrice, salePrice, color, tricycle.WheelNumber, horsepower);
            }


        }

    }

    private static void ShowCarRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, decimal salePrice, string color, int doorsNumber, string fuelType, decimal horsepower)
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Carro cadastrado com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de venda: {salePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Quantidade de portas: {doorsNumber}");
        Console.SetCursorPosition(3, 12);
        Console.Write($"Combustivel: {fuelType}");
        Console.SetCursorPosition(3, 13);
        Console.WriteLine($"Potência: {horsepower} cavalos");


    }

    private static void ShowPickupRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, decimal salePrice, string color, int doorsNumber, string fuelType, decimal horsepower, decimal pickupTruckCapacity)
    {
        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Camionete cadastrado com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de venda: {salePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Quantidade de portas: {doorsNumber}");
        Console.SetCursorPosition(3, 12);
        Console.Write($"Combustivel: {fuelType}");
        Console.SetCursorPosition(3, 13);
        Console.WriteLine($"Potência: {horsepower} cavalos");
        Console.SetCursorPosition(3, 14);
        Console.WriteLine($"Capacidade da caçamba: {pickupTruckCapacity} litros");


    }

    private static void ShowMotoOrTricycleRegistered(int fabricationYear, string name, string plate, Guid chassisNumber, decimal purchasePrice, decimal salePrice, string color, int wheelNumber, decimal horsepower)
    {

        Console.Clear();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Camionete cadastrado com sucesso!");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Name: {name}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Número de Chassi: {chassisNumber}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Placa: {plate}");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Ano de fabricação: {fabricationYear} ");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de venda: {salePrice} reais");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 10);
        Console.Write($"Cor: {color}");
        Console.SetCursorPosition(3, 11);
        Console.Write($"Quantidade de rodas: {wheelNumber}");
        Console.SetCursorPosition(3, 12);
        Console.WriteLine($"Potência: {horsepower} cavalos");
    }
}
