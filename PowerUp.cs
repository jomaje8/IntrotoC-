using System;
public class PowerUp {
public int power = 10;
public float duration =2;

public void RunPowerup () {
    Console.WriteLine("PowerUp Ran");
    }

    public void RechargePowerup (int _power) {
        power += _power;
        Console.WriteLine("Recharged Power up to " + power);
    }
}

