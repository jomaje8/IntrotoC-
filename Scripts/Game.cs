using System;
public class Game{

    public Game(){
        Health.power = 100;
        Health.message = "you are getting stronger";
        Ammo.message = "You have more ammo";
    }

    public void start (){
        Health.RunPowerUp();
        /*
        After prompt the game for a new game we:
        Enter a cave
        find Health.
        Meet a dragon (need an Enemy class)
        Pick a weapon.
        Battle dragon. (Battle class)
        If we win:get Health and ammo
        If dragon wins: loose health:


        */
    }
    


// Game PowerUps
public PowerUpBase Health = new PowerUpBase();
public PowerUpBase Ammo = new PowerUpBase();


//Game Weapons
    private WeaponBase Gun = new WeaponBase();

    private WeaponBase Knife = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    public string name;

    private int score;

}