using RPGProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                switch (args[1])
                {
                    case "-v":
                        MessageBox.Show("Version Number 0.1");
                        break;
                    case "dev":
                        //edits current save linked to the game
                        //if no save is detected it should give the dev the default player
                        //normal players wont be able to enter the game with default player
                        Player player = SaveManagement.LoadPLayer();
                        Weapon DevWep = Weapon.LoadDeveloperSword();
                        Armour DevAr = Armour.LoadDeveloperArmour();
                        player.currentWeapon = DevWep;
                        player.currentArmour = DevAr;
                        player.weapons.Add(DevWep); 
                        player.armours.Add(DevAr);
                        SaveManagement.SavePlayer(player);
                        MessageBox.Show(player.name + " Now Has Cheats!");
                        break;
                        default:
                        MessageBox.Show("Wrong Command /n -v For Version /n dev For Developer Equipment");
                        break;
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
