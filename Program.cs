using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Title = "Ghoster - by kerle.xyz";

        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    static bool MainMenu()
    {
        Console.Out.Flush();
        Console.Clear();

        Console.WriteLine(@"  
                                ▄████  ██░ ██  ▒█████    ██████ ▄▄▄█████▓▓█████  ██▀███  
                                ██▒ ▀█▒▓██░ ██▒▒██▒  ██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒
                               ▒██░▄▄▄░▒██▀▀██░▒██░  ██▒░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒
                               ░▓█  ██▓░▓█ ░██ ▒██   ██░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  
                               ░▒▓███▀▒░▓█▒░██▓░ ████▓▒░▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒
                                ░▒   ▒  ▒ ░░▒░▒░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░
                                 ░   ░  ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░
                               ░ ░   ░  ░  ░░ ░░ ░ ░ ▒  ░  ░  ░    ░         ░     ░░   ░ 
                                     ░  ░  ░  ░    ░ ░        ░              ░  ░   ░     by kerle.xyz");
        Console.WriteLine();
        Console.WriteLine("1) IP");
        Console.WriteLine("2) Discord");
        Console.WriteLine("3) GitHub");
        Console.WriteLine("4) Exit");
        Console.Write("\n= ");

        switch (Console.ReadLine())
        {
            case "1":
                StartPrank();
                return true;
            case "2":
                OpenLink("https://discord.gg/98fADjcFVv");
                PauseBeforeContinuing();
                return true;
            case "3":
                OpenLink("https://github.com/kerlexyz");
                PauseBeforeContinuing();
                return true;
            case "4":
                Console.WriteLine("Exiting...");
                return false;
            default:
                Console.WriteLine("Invalid option, try again.");
                PauseBeforeContinuing();
                return true;
        }
    }

    static void StartPrank()
    {
        Console.WriteLine("Prank started! Press any key to stop.");

        // Open multiple cmd windows with "Prank!" message
        for (int i = 0; i < 10; i++) // Change 5 to however many windows you want to open
        {
            // Start a new command prompt and run a command to display "Prank!"
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c mode con: cols=18 lines=6 & COLOR fd & echo LMAO LMAO LMAO LMAO LMAO & pause")
            {
                UseShellExecute = true, // Must be true to open a new window
                CreateNoWindow = false   // Set to false to see the window
            };
            Process.Start(psi);

            // Wait a moment before opening the next window
            System.Threading.Thread.Sleep(0); // Adjust the delay (milliseconds) as needed
        }

        Console.Clear();
        Console.WriteLine("Thanks for playing along.");
        PauseBeforeContinuing();
    }

    static void OpenLink(string url)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // This is important to open the URL in the default browser
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not open the link: " + ex.Message);
        }
    }

    static void PauseBeforeContinuing()
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}