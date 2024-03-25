using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace highsail_text_rpg
{
    internal class MainMenu
    {

        string folderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/textRPG/Saves";//@".\Saves";

        bool bSaveFolderExist = false;
        bool bSaveFileExist = false;
        bool bStillInMenus = true;

        public bool SavedFolderExist => bSaveFolderExist;
        public bool SaveFileExist => bSaveFileExist;
        public bool StillInMenus => bStillInMenus;

        private void CheckSaveFolder()
        {
            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("Found Save folder!");
                bSaveFolderExist = true;
                if (File.Exists($"{folderPath}/player.json"))
                {
                    Console.WriteLine("Found save file!");
                    bSaveFileExist = true;
                }
            }
            else
            {
                Console.WriteLine("No save folder found!\nCreating new one!");
                Directory.CreateDirectory(folderPath);

            }
        }

        public void ShowStartMenu()
        {
            Console.Clear();
            CheckSaveFolder();
            Console.WriteLine("Welcome to <Name of Game>! Please pick between these options!");
            Console.WriteLine("\n\nNew Game");
            if (bSaveFileExist)
                Console.WriteLine("Load Game");
            Console.WriteLine("Quit");
        }

        //public void ShowOptionsMenu()
        //{

        //}

        public void ShowLoadMenu()
        {
            Console.Clear();
            Console.WriteLine($"Please pick from the list of aviable characters!");
            Console.WriteLine($"For now we're kicking back to start menu.");
            _ = DelayShowStart();
        }

        public void ShowCreateMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome Player, please begin creating your character!");
            Console.WriteLine($"Okay here we will ask for information then once the character creator is done we'll supply all the information for the class");
            Console.WriteLine($"For now we'll just hop back to main menu. after a few seconds");
            _ = DelayShowStart();
        }

        //Temp just for ensuring menus are working correctly
        static async Task DelayShowStart()
        {
            await Task.Delay(5000);
            MainMenu menu = new MainMenu();
            menu.ShowStartMenu();
        }

    }
}
