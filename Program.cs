using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ammo;
            ammo = new int[3];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 20;
            Console.WriteLine("ammo system:");

            int weapon = 1;

            Console.WriteLine("before arrays:");
            int pistolAmmo = 6;
            int shotGunAmmo = 2;
            int bfgAmmo = 20;

            if (weapon == 0)
            { 
                Console.WriteLine("Pistol Ammo: " + ammo[0]); 
            }
            
            else if (weapon == 1)
            {
                Console.WriteLine("Pistol Ammo: " + ammo[1]);
            }

            else if (weapon == 2)
            {
                Console.WriteLine("Pistol Ammo: " + ammo[2]);
            }

            Console.WriteLine("Ammo: " + ammo[weapon]);

            Console.WriteLine("arrays:");

            int lives = 3;

            
            ammo = new int[3];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 20;

            string[] weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shot Gun";
            weaponName[2] = "BFG";

            Console.WriteLine("Pistol Ammo: " + ammo);
            Console.WriteLine("shotGunAmmo: " + ammo);
            Console.WriteLine("bfgAmmo: " + ammo);



            Console.ReadKey(true);
        }
    }
}
