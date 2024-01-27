using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Reflection;

namespace RockPaperScissor
{
    internal class RockPaperScissor
    {
        static void Main()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            string playersChoice = string.Empty;

            while (playersChoice != "n" || playersChoice != "no")
            {
                Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock" || playerMove == "Rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper" || playerMove == "Paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors" || playerMove == "Scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again...");
                    return;
                }

                Random random = new Random();

                int randomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (randomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The computer's choice: {computerMove}");

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                         (playerMove == Paper && computerMove == Scissors) ||
                         (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Draw");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Do you want to try again? [y]yes [n]no: ");
                playersChoice = Console.ReadLine();

                if (playersChoice == "y" || playersChoice == "yes")
                {
                    continue;
                }
                else if (playersChoice == "n" || playersChoice == "no")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Thank you for playing");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again...");
                    break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
