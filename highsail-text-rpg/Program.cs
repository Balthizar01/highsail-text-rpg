using highsail_text_rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowStartMenu();
            string input = string.Empty;
            bool bValidChoic = false;
            while (true)
            {
                input = Console.ReadLine();

                while (!bValidChoic)
                {
                    switch (input.ToLower())
                    {
                        case "new game":
                        case "new":
                        case "ng":
                            mainMenu.ShowCreateMenu();
                            bValidChoic = true;
                            break;

                        case "load game":
                        case "load":
                        case "lg":
                            if (mainMenu.SaveFileExist)
                            {
                                mainMenu.ShowLoadMenu();
                                bValidChoic = (true);
                            }
                            else
                            {
                                Console.WriteLine("No save files found, please make another selection");
                                input = Console.ReadLine();
                            }
                            break;

                        case "quit":
                        case "q":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine($"Wrong input pelase pick from New Game {(mainMenu.SaveFileExist ? ", Load Game," : "")}or Quit!");
                            input = Console.ReadLine();
                            break;
                    }
                }
                Console.ReadLine();
                bValidChoic = false;
                input = string.Empty;
            }
        }
    }
}
