using System;
public class Game {
    
    public Game() {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more Ammo.";
        Cave.StartMessage = "You have entered the scary cave";
        UnderWater.Objects = new string[] {"Seawead", "Coral" ,"Fish", "Shark"};
    }
    //Runs at start of game
         public void Start(){
        Console.WriteLine("Please type your name:");
        name = Console.ReadLine();
        Console.WriteLine("Your player name is " + name);
        Cave.enter();
        while(Game.canPlay){
        GameTimer();
        Play();
        }
        Console.WriteLine("You Died");
        Console.WriteLine("Game OVer");
    }

    private void Play (){
        Random randomeNum = new Random();
        Cave.Encounter(randomeNum.Next(0, Cave.Objects.Length));
    }

    if(gameState == "end") {
        Console.Writeline("Game Over")
        Enviornment.Exit(0);
    }

    if(gameState == "help"){
        Console.Writeline("What do you need help for? If you can't play this game, you have issues.")
}

    if(gameState != "help" \\ gameState != "play" \\ gameState != "end") {
        Console.writeline(gameState = " is not a valid option.")
    }
    public static void GameTimer (){
         System.Threading.Thread.Sleep(2000);

    }
    // game levels
        private Levelbasics Cave = new Levelbasics();
        public static Levelbasics UnderWater = new Levelbasics();
    //game power ups
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

//game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Riffle = new WeaponBase();
    public string name;
    private int score;
    public static bool canPlay = true;

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