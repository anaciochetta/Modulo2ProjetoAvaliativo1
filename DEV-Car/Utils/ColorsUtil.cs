namespace DevCar.Utils;


public static class ColorsUtil
{
    //método para imprimir as opções de cores 
    public static int PrintColorsOptions()
    {
        MenuUtils.DrawCanvas();
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Digite a cor desejada:");

        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Preto");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Vermelho");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Azul");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("4 - Roxo");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("5 - Prata");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("**Camionetes são fabricadas somente na cor Roxa**");

        Console.SetCursorPosition(3, 13);
        Console.Write("Digite a opção: ");

        int color = int.Parse(Console.ReadLine());

        switch (color)
        {

            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            case 4:
                return 4;
            case 5:
                return 5;
            default:
                return 1;
        }
    }
}