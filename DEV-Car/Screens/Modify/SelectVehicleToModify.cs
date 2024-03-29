using DevCar.Repositories;
using DevCar.Models;
using DevCar.Utils;
using DevCar.Validators;

namespace DevCar.Screens.Modify;

public static class SelectVehicleToModify
{
    public static void Init()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        SelecVehicleToModify();
    }
    //tela para colocar a placa do veículo para modificação
    private static void SelecVehicleToModify()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite a placa do veículo para modificação:");
        string plate = ReadPlate();

        if (VehicleRepositoryList.VerifyExistentPlate(plate))
        {
            ConfirmVehicle(plate);
        }
        else
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa não encontrada!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Deseja tentar novamente? (S ou N)");
            Console.SetCursorPosition(3, 8);
            string answer = Console.ReadLine();
            if (answer == "S" || answer == "s")
            {
                Console.Clear();
                SelecVehicleToModify();
            }
            else if (answer == "N" || answer == "n")
            {
                Console.Clear();
                MenuScreen.Init();
            }
            else
            {
                Console.WriteLine("Resposta Inválida, tente novamente!");
                ConfirmVehicle(plate);
            }
        }
    }
    //tela para confirmar o veículo selecionado
    private static void ConfirmVehicle(string plate)
    {
        MenuUtils.DrawSimpleCanvas();
        Console.WriteLine("Este é o veículo que deseja alterar?");
        Vehicle? vehicle = VehicleRepositoryList.GetByPlate(plate);
        System.Console.WriteLine(vehicle.ListVehicleInfo());
        System.Console.WriteLine("");
        System.Console.WriteLine("Digite S para sim e N para não");
        string answer = Console.ReadLine();
        MenuUtils.PrintHorizontalLine();
        if (answer == "S" || answer == "s")
        {
            ModifyVehicleScreen.Init(plate);
        }
        else if (answer == "N" || answer == "n")
        {
            SelecVehicleToModify();
        }
        else
        {
            System.Console.WriteLine("Resposta Inválida, tente novamente!");
            ConfirmVehicle(plate);
        }
    }

    public static string ReadPlate()
    {
        Console.SetCursorPosition(3, 4);
        Console.Write("Placa: ");
        string plate = Console.ReadLine();

        while (!ValidateInputPlate.Validate(plate))
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Placa inválida!");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Aperte 'ENTER' para inserir novamente");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Digite a placa do veículo para modificação:");
            Console.SetCursorPosition(3, 4);
            Console.Write("Placa: ");
            plate = Console.ReadLine();
        }
        return plate;
    }
}