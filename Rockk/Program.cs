using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Rock, Paper, Scissors ===");

            Random random = new Random();
            int playerScore = 0;
            int computerScore = 0;
            bool playAgain = true;

            while (playAgain)
            {
                // --- get the player's move ---
                Console.Write("\nChoose (rock/paper/scissors): ");
                string? input = Console.ReadLine();
                string playerChoice = input != null ? input.Trim().ToLower() : "";

                if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine("Please type rock, paper, or scissors.");
                    continue; // skip the rest and ask again, doesn't count as a round
                }

                // --- get the computer's move ---
                int randomIndex = random.Next(0, 3); // gives 0, 1, or 2
                string computerChoice = "";

                if (randomIndex == 0)
                {
                    computerChoice = "rock";
                }
                else if (randomIndex == 1)
                {
                    computerChoice = "paper";
                }
                else
                {
                    computerChoice = "scissors";
                }

                Console.WriteLine($"You chose: {playerChoice}");
                Console.WriteLine($"Computer chose: {computerChoice}");

                // --- decide the winner ---
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (
                    (playerChoice == "rock" && computerChoice == "scissors") ||
                    (playerChoice == "paper" && computerChoice == "rock") ||
                    (playerChoice == "scissors" && computerChoice == "paper")
                )
                {
                    Console.WriteLine("You win this round!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!");
                    computerScore++;
                }

                Console.WriteLine($"Score -> You: {playerScore} | Computer: {computerScore}");

                // --- play again? ---
                Console.Write("\nPlay another round? (y/n): ");
                string? answer = Console.ReadLine();
                playAgain = answer != null && answer.Trim().ToLower() == "y";
            }

            Console.WriteLine("\n=== Final Score ===");
            Console.WriteLine($"You: {playerScore} | Computer: {computerScore}");

            if (playerScore > computerScore)
            {
                Console.WriteLine("You won overall! 🎉");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("Computer won overall. Better luck next time!");
            }
            else
            {
                Console.WriteLine("Overall it's a tie!");
            }

            Console.WriteLine("\nThanks for playing! Goodbye.");


        }
    }
}
