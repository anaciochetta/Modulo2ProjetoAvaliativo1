using DevCar.Screens;

namespace DevCar.Utils;

public static class MenuUtils
{
    //desenha o quadradadinho
    public static void DrawCanvas()
    {
        PrintHorizontalLine();

        for (int line = 0; line <= 12; line++)
        {
            Console.Write("|");
            for (int i = 0; i <= 45; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
        }

        PrintHorizontalLine();
    }
    public static void PrintHorizontalLine()
    {
        Console.Write("+");
        for (int i = 0; i <= 45; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }

    //método para voltar ao menu principal
    public static void ControlKey()
    {
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para voltar ao menu...");
        ConsoleKeyInfo key;
        bool isEnter = true;
        while (isEnter)
        {
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                isEnter = false;
                break;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MenuScreen.Init();
            }
        }
    }

    public static void DrawSimpleCanvas()
    {
        Console.Clear();
        PrintHorizontalLine();
    }
}