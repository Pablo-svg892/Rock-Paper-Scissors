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
                

        }
    }
}
