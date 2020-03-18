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
            Console.WriteLine("                   Let's play the 'Big Bang Theory shows's game of:  Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine("     B     B      T              'Scissors cuts paper, paper covers rock,                                              ");
            Console.WriteLine("      I     A      H              rock crushes lizard, lizard poisons Spock,                                           ");
            Console.WriteLine("       G     N      E            Spock smashes scissors, scissors decapitate lizard,                                   ");
            Console.WriteLine("              G      O          lizard eats paper, paper disproves Spock,                                              ");
            Console.WriteLine("                      R         Spock vaporizes rock.And as it always has, rock crushes scissors.'                     ");    
            Console.WriteLine("                       Y                  --Dr. Sheldon Cooper                                                         ");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine(" Game Rules                                                                                                            ");
            Console.WriteLine("Rock beats: Scissors, Lizard                                                                                           ");
            Console.WriteLine("Paper beats: Rock, Spock                                                 GESTURE SELECTION                             ");
            Console.WriteLine("Scissors beats: Lizard, Paper                          1 = Rock, 2 = Paper, 3 = Scissors, 4 = Lizard, 5 = Spock        ");
            Console.WriteLine("Lizard beats: Paper, Spock                                               S = Single Player                             ");
            Console.WriteLine("Spock beats: Rock, Scissors                                              M = Multiplayer                               ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                  HIT ENTER TO BEGIN!                                                  ");

            Console.ReadLine();

            GameplayRules();
        }

        // member methods (CAN DO)
    }
}
