using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays:");
            Console.WriteLine();

            int weapon = 0;

            string[] weaponName;
            weaponName = new string[5];
            weaponName[0] = "Pistol: ";
            weaponName[1] = "Shotty: ";
            weaponName[2] = "Lazer: ";
            weaponName[3] = "Sniper: ";
            weaponName[4] = "Boom Boom Machine: ";

            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6; //pistol 
            ammo[1] = 2; // shotty
            ammo[2] = 50; // lazer
            ammo[3] = 25;  // sniper
            ammo[4] = 10; // rocket launcher

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);

            weapon = 3;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);

            weapon = 1;

            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine(ammo[weapon]);

            Console.ReadKey(true);
        }
    }
}
