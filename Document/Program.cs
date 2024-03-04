using Document.DocumentProgram;
using Document.ExpertDocument;
using Document.ProDocumentProgram;

Menu();
void Menu()
{
    int select = 1;
    string[] menu = new string[3]
{
    "Basic",
    "Pro",
    "Expert"
};
    do
    {
        Console.Clear();
        switch (select)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var item in menu)
                {
                    if (item == menu[0])
                    {
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
                break;
            case 2:
                foreach (var item in menu)
                {
                    if (item == menu[1])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
                break;
            case 3:
                foreach (var item in menu)
                {
                    if (item == menu[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
                break;
            default:
                break;
        }
        ConsoleKeyInfo info = Console.ReadKey(true);
        if (info.Key == ConsoleKey.UpArrow)
        {
            if (select != 1)
            {
                select--;
            }
            else
            {
                select = 3;
            }
        }
        else if (info.Key == ConsoleKey.DownArrow)
        {
            if (select != 3)
            {
                select++;
            }
            else
            {
                select = 1;
            }
        }
        else if (info.Key == ConsoleKey.Enter)
        {
            if (select == 1)
            {
                Console.Clear();
                DocumentProgram docProgram = new DocumentProgram();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine("\nPress any key...");
                info = Console.ReadKey(true);
            }
            else if (select == 2)
            {
                Console.Clear();
                DocumentProgram docProgram = new ProDocumentProgram();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine("\nPress any key...");
                info = Console.ReadKey(true);
            }
            else
            {
                Console.Clear();
                DocumentProgram docProgram = new ExpertDocument();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine("\nPress any key...");
                info = Console.ReadKey(true);
            }
        }
    } while (true);
}