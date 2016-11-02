using System;
public class Levelbasics{

    public string StartMessage;
    public bool entranceOpen = true;
    public string[] environment = {"Cold","Wet","Dark"};

    public string[] Objects = {"rocks", "Ravine", "River", "Lava"};

    public void enter(){
        Console.WriteLine(StartMessage);
        
            }
    public void Encounter(int i){
            switch (i)
            {
                case 0:
                Console.WriteLine("You have walked into " + Objects[i]);

                break;

                case 1:
                Console.WriteLine("You have walked into " + Objects[i]);

                break;

                case 2:
                Console.WriteLine("You have walked into " + Objects[i]);
                Game.GameTimer();
                Random randomeNum = new Random();
                 Game.UnderWater.Encounter(randomeNum.Next(0, Game.UnderWater.Objects.Length));

                break;

                case 3:
                Console.WriteLine("You have walked into " + Objects[i]);
                //lave kills us.
                    Game.canPlay = false;
                break;

                default:
                    Console.WriteLine("Your Path is clear.");
                    break;
            }
    }
}