namespace DevCar.Utils;

class FuelUtil
{
    //método para imprimir os tipos de combustível para carro
    public static int PrintCarFuelOptions()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite o combustível desejado:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Gasolina");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Flex");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        int fuel = int.Parse(Console.ReadLine());

        switch (fuel)
        {

            case 1:
                return 10;
            case 2:
                return 20;
            default:
                return 10;
        }
    }
    //método para imprimir os tipos de combustível para camionete
    public static int PrintPickupFuelOptions()
    {
        Console.Clear();
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite o combustível desejado:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Gasolina");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Diesel");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        int fuel = int.Parse(Console.ReadLine());

        switch (fuel)
        {

            case 1:
                return 10;
            case 2:
                return 30;
            default:
                return 10;
        }
    }
}