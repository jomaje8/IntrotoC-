public class ShieldsPowerUp: PowerUpBase { // this line of code inherits the orginal attributes of the public class "PowerUpBase"
    public int ShieldLevels = 100;
    public void RunShields () {
        power = 1000;
        RunPowerUp();
    }

}