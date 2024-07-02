namespace EditorHtml;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue; // trocando a cor de fundo
        Console.ForegroundColor = ConsoleColor.Black; // trocando a cor da fonte

        DrawScreenColumn();
        DrawScreenLine();
        DrawScreenDown();
        WriteOptions(); // escrevendo , opções

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }

    public static void DrawScreenColumn()
    {
        Console.Write("+");

        for (int i = 0; i <= 30; i++) 
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");
    }

    public static void DrawScreenLine() 
    {
        for (int lines = 0; lines <= 10; lines++) 
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
    }

    public static void DrawScreenDown() 
    {
        for (int i = 0; i <= 30; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write('\n');
    }

    public static void WriteOptions() // escrevendo as opções para usuários
    {
        Console.SetCursorPosition(3, 2); // escrevendo algo específico na tela
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("============");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 => Novo Arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 => Abrir");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 => Sair");
        Console.SetCursorPosition(3, 10);
        Console.Write("Opção: ");

    }

    public static void HandleMenuOption(short option) // Manipular
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }

}
