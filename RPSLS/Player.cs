using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {

        int playerChoice;

        public Player()
        {
            playerChoice = ChooseMove();

            switch(playerChoice)
            {

                case 1:
                    Console.WriteLine($"Player has chosen Rock");
                    break;
                case 2:
                    Console.WriteLine($"Player has chosen Paper");
                    break;
                case 3:
                    Console.WriteLine($"Player has chosen Scissors");
                    break;
                case 4:
                    Console.WriteLine($"Player has chosen Lizard");
                    break;
                case 5:
                    Console.WriteLine($"Player has chosen Spock");
                    break;
                default:
                    Console.WriteLine("Please make a valid choice");
                    break;
            }
        }

        public int ChooseMove()
        {
            Console.WriteLine($"Please make a choice; \n" +
                $"1. Rock\n" +
                $"2. Paper\n" +
                $"3. Scissors\n" +
                $"4. Lizard\n" +
                $"5. Spock\n");

            string userChoice = Console.ReadLine();
            int choice = Convert.ToInt32(userChoice);
            return choice;
        }


    }
}
