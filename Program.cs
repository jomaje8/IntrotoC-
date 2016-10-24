using System;
public class Program
{

    public static Game myGame = new Game();
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name Kwasia!");
        myGame.name = Console.ReadLine();
        Console.WriteLine("Your Players Name is " + myGame.name);
    }
}
