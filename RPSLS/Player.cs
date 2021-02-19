using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {

        string playerChoice;

        public Player(string playerChoice)
        {

            this.playerChoice = playerChoice;

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
