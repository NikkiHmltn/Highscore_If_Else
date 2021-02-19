using System;

namespace Highscore
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an app with a score, highscore, and a highscorePlayer
            //create a method with two params, one for score and the other for playerName
            //whenmethod is called, check if the score of the player is higher than thehighscore
            int score;
            string playerName;
            bool scoreCheck;
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.WriteLine("What is your score?");
            string scoreInput = Console.ReadLine();
            scoreCheck = int.TryParse(scoreInput, out score);

            if (scoreCheck)
            {
               NewScore(score, playerName);
            } else
            {
                Console.WriteLine("Please enter a number.");
            }
            
        }
        public static void NewScore(int score, string playerName)
        {
            int highscore = 20;
            string highscorePlayer = "Nikki";

            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("Congratulations! You beat the highscore!");
                Console.WriteLine("New score, {0} by {1}", highscore, highscorePlayer);
            } else if (score == highscore)
            {
                Console.WriteLine("You tied for highscore! Try getting points higher than ({0}) to get the highscore place!", highscore);
            } else
            {
                Console.WriteLine("You did not get enough to beat the highscore ({0}). Try again!", highscore);
            }
        }
    }
}
