using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{
    class Gameplay
    {
        // member variables (HAS A)
        Player player1;
        Player player2;


        //constructor {ENTER ctor tab tab to get template}
        public Gameplay()
        {
           /* player1 = new Human();  */            //comment this section out until their respective class' are completed.
            player2 = new Player();
        }

       
        public void GameplayRules()
        {
            Console.WriteLine("Let's play the 'Big Bang Theory shows's game of:  Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine("GAME RULES");
            Console.WriteLine("Rock beats: Scissors, Lizard");
            Console.WriteLine("Paper beats: Rock, Spock                              GESTURE SELECTION");
            Console.WriteLine("Scissors beats: Lizard, Paper                          1 = Rock, 2 = Paper, 3 = Scissors, 4 = Lizard, 5 = Spock");
            Console.WriteLine("Lizard beats: Paper, Spock                              S = Single Player");
            Console.WriteLine("Spock beats: Rock, Scissors                             M = Multiplayer");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();

            GameplayRules();
        }

        // member methods (CAN DO)
    }
}
