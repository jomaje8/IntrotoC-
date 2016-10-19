using System;
    public class Program
    { 
        
         public static PowerUp health;
         public static PowerUp Ammo = new PowerUp();
        public static void Main(string[] args)
        {
            health = new PowerUp();
            health.duration = 10;
            health.RunPowerup();
            Console.WriteLine("health.duration");
             Ammo.RunPowerup();


             health.RechargePowerup(20);
             Ammo.RechargePowerup(300);

        }
    }
