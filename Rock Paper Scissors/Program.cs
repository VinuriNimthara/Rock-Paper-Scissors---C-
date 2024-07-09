using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            while(playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player Score - " + playerScore +".Enemy Score - " +  enemyScore);
                Console.WriteLine("Please enter 'r' for rock , 'p' for paper or anything else for scissors");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0,3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins the round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins the round.");
                            enemyScore++; 
                            break;
                       
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins the round.");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins the round.");
                            playerScore++;
                            break;
                                                }
                }
                else 
                {
                    Console.WriteLine("Enemy chooses scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins the round.");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins the round.");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }
            if (playerScore == 3 )
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
