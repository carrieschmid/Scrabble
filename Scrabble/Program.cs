using System;
using Scrabble.Models;

class Program 
{
    public static void Main () 
    {
        bool runGame = true;
        while(runGame)
        {
            RunGame();
            Console.WriteLine("Want to score another word? [Y/N]");
            string anotherWord = Console.ReadLine().ToLower();
            if(anotherWord != "y")
            {
                runGame = false;
            }

        }

    }

    public static void RunGame () 
    {
        Console.WriteLine ("Please Enter a Word:");
        Game game = new Game ();
        bool exitRetry = false;
        string response = "";
        while (!exitRetry) {
            response = Console.ReadLine ();
            exitRetry = game.CheckInput (response);
            if (!exitRetry) {
                Console.WriteLine ("Please enter only alphabetic letters and try again.");
            }
        }
        response = game.CheckMultipleWords (response);
        int score = game.WordScore (response);

        Console.WriteLine ("The word \"" + response + "\" score is: " + score.ToString ());
    }
}