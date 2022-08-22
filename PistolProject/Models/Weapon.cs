using System;
using System.Collections.Generic;
using System.Text;

namespace PistolProject.Models
{
    class Weapon
    {
        private int _weaponCapacity;//gulle tutumu
        private int _weaponBulletCount;//gulle sayi
        private int _weaponDischargeTime;//gulle bosalma vaxti
        private string _shootingMode; //gulle atis sekli tekli ve ya avtomatik


        public Weapon(int weaponCapacity,int weaponBulletCount,int weaponDischargeTime,string shootingMode)
        {
            WeaponCapacity = weaponCapacity;
            WeaponBulletCount = weaponBulletCount;
            WeaponDischargeTime=weaponDischargeTime; 
            ShootingMode = shootingMode;
        }
        public int WeaponCapacity { 
            get
            {
                return _weaponCapacity;
            } 
            set
            {
                if (value>0)
                {
                    _weaponCapacity = value;
                }
             
            } 
        }
        public int WeaponBulletCount { 
            get
            {
                return _weaponBulletCount;
            } 
            set
            {
                if (value>=0 && value<= WeaponCapacity) 
                {
                    _weaponBulletCount = value;
                }
              
            }
        }
        public int WeaponDischargeTime { 
            get
            { 
                return _weaponDischargeTime;
            } set
            {
                if (value>=0 && value<=WeaponCapacity )
                {
                    _weaponDischargeTime = value;
                }
                
            } 
        }
        public string ShootingMode {
            get {
                return _shootingMode;
            } 
            set
            {
                if (value=="Single mode" || value=="Automatic mode" )
                {
                    _shootingMode = value;
                }
            } 
        }
        public  int Shoot()
        {

            if (WeaponBulletCount > 0)
            {
                WeaponBulletCount = WeaponBulletCount - 1;
                Console.WriteLine("1 bullet is shooted");
                Console.WriteLine("currenty bullets:");
            }
            return WeaponBulletCount;
        }
        public void Fire()
        {
            int time=0;
            if (ShootingMode=="Automatic mode")
            {
                while (WeaponBulletCount > 0)
                {
                    WeaponBulletCount = WeaponBulletCount - 1;
                     time++;

                }
                
                Console.WriteLine("currenty bullets: "+ WeaponBulletCount);
                Console.WriteLine(time + "second spent  ");
            }
            else if(ShootingMode=="Single mode")
            {
                Console.WriteLine(Shoot());
                Console.WriteLine("1 second spent");
            }
             
           
        }
        public int GetRemainBulletCount()
        {
            Console.WriteLine("remain bullets");
            return WeaponCapacity-WeaponBulletCount;
        }
        public int Reload()
        {
            while (WeaponCapacity>WeaponBulletCount)
            {
                WeaponBulletCount++;
            }
            Console.WriteLine("weapon is reloaded ,current bullets:");
            return WeaponBulletCount;
        }
        public void ChangeFireMode()
        {
            if (ShootingMode=="Automatic mode")
            {
                ShootingMode = "Single mode";
                Console.WriteLine("mode is change");
            }
            else if (ShootingMode == "Single mode") 
            {
                ShootingMode = "Automatic mode";
                Console.WriteLine("mode is change");
            }
        }
    }
}
