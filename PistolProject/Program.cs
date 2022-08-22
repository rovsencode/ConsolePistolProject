using PistolProject.Models;
using System;

namespace PistolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
         
        public static void MainMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Please input  capacity:");
            int weaponCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input bullet count:");
            int weaponBulletCount = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Please input dischargetime");
            int weaponDischargeTime = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("please input shoot mode:Single mode or Automotic mode");
            string shootingMode = Console.ReadLine();
            Weapon silah = new Weapon(weaponCapacity, weaponBulletCount, weaponDischargeTime, shootingMode);
        Input:
            GetMenu();
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {


                case 0:
                    Console.WriteLine("\nBullet Capacity: " + silah.WeaponCapacity +
                        "\nBullet Count: " + silah.WeaponBulletCount +
                        "\nDischarge Time: " + silah.WeaponDischargeTime +
                        "\nFire mode: " + silah.ShootingMode);
                    break;
                case 1:
                    Console.WriteLine(silah.Shoot());
                    break;
                case 2:
                    silah.Fire();
                    break;
                case 3:
                    Console.WriteLine(silah.GetRemainBulletCount());
                    break;
                case 4:
                    Console.WriteLine(silah.Reload());
                    break;
                case 5:
                    silah.ChangeFireMode();
                    break;
                case 7:
                    Console.WriteLine("please input key: \nT-new for capacity \nS-new for bullet count \nD-new for Discharge time");
                   string key = (Console.ReadLine());
                    if (key=="T")
                    {
                        Console.WriteLine("new value");
                        silah.WeaponCapacity= Convert.ToInt32(Console.ReadLine());
                    }
                    else if (key=="S")
                    {
                        Console.WriteLine("new value ");
                        silah.WeaponBulletCount= Convert.ToInt32(Console.ReadLine());
                    }
                    else if (key=="D")
                    {
                        Console.WriteLine("new value");
                        silah.WeaponDischargeTime= Convert.ToInt32(Console.ReadLine()); 
                    }
                    break;
                default:
                    Console.WriteLine("\nwrong input");
                    break;
            }
            if (input!=6)
            {
                goto Input;
            }
        }
        public static void GetMenu()
        {
            Console.WriteLine("\nWhat are you doing?");
            Console.WriteLine("0 -About Information Weapon");
            Console.WriteLine("1 - Shoot");
            Console.WriteLine("2 - Fire");
            Console.WriteLine("3 -  Requried bullet count for reolad");
            Console.WriteLine("4 - Reolad bullet ");
            Console.WriteLine("5 -Change fire mode ");
            Console.WriteLine("6 - Exit from program");
            Console.WriteLine("7 - Do edit:");
          

        }
    }
}
