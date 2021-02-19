using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI
    {

        Random rand;


        public AI()
        {

            rand = new Random();

        }

        public int ChooseMove()
        {
            int moveChoice = rand.Next(4);
            //Console.WriteLine($"{moveChoice}");
            

            switch (moveChoice)
            {
                case 0:
                    Console.WriteLine($"Computer Chooses {moveChoice}");
                    return moveChoice;
                case 1:
                    Console.WriteLine($"Computer Chooses {moveChoice}");
                    return moveChoice;
                case 2:
                    Console.WriteLine($"Computer Chooses {moveChoice}");
                    return moveChoice;
                case 3:
                    Console.WriteLine($"Computer Chooses {moveChoice}");
                    return moveChoice;
                case 4:
                    Console.WriteLine($"Computer Chooses {moveChoice}");
                    return moveChoice;
                default:
                    return moveChoice;

            }

        }
        


    }

    
}
