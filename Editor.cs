using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Show() 
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------");
        Start();
    }

    public static void Start() 
    {
        var file = new StringBuilder();

        do 
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("---");
        Console.WriteLine("  Deseja salvar o arquivo? [Y] Yes [N] No");
        Console.WriteLine("---");

        var keyinfo = Console.ReadKey();
        char option = keyinfo.KeyChar;

        switch (option)
        {
            case 'y': Viewer.Show(file.ToString()); break;
            case 'n': Console.WriteLine("No Saved"); break;
            default: Menu.Show(); break;
        }
    }
}