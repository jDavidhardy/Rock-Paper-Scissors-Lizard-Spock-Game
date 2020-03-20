using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{

    public class Gameplay
    {
        // member variables (HAS A)
        public Player player1;
        public Player player2;
        int playerOneScore;
        int playerTwoScore;
        public int minPlayerScore = 0;
        public int maxPlayerScore = 3;

        public Gameplay()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        public void GameplayRules()

        //methods
        // 1st Display Screen
        {
            Console.WriteLine("                   Let's play the 'Big Bang Theory shows's game of:  Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine("     B     B      T              'Scissors cuts paper, paper covers rock,                                              ");
            Console.WriteLine("      I     A      H              rock crushes lizard, lizard poisons Spock,                                           ");
            Console.WriteLine("       G     N      E            Spock smashes scissors, scissors decapitate lizard,                                   ");
            Console.WriteLine("              G      O          lizard eats paper, paper disproves Spock,                                              ");
            Console.WriteLine("                      R         Spock vaporizes rock. And as it always has, rock crushes scissors.'                    ");
            Console.WriteLine("                       Y                  --Dr. Sheldon Cooper                                                         ");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine(" Game Rules                                                              GESTURE SELECTION                             ");
            Console.WriteLine("Rock beats: Scissors, Lizard                              1 = Rock, 2 = Paper, 3 = Scissors, 4 = Lizard, 5 = Spock     ");
            Console.WriteLine("Paper beats: Rock, Spock                                                                                               ");
            Console.WriteLine("Scissors beats: Lizard, Paper                                               GAME MODE                                  ");
            Console.WriteLine("Lizard beats: Paper, Spock                                   s = Single Player        (Player vs. Computer)            ");
            Console.WriteLine("Spock beats: Rock, Scissors                                  m = Multiplayer          (Player vs. Player )             ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                  HIT ENTER TO BEGIN!                                                  ");
            Console.ReadLine();
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("What game mode do you want to play? Enter 's' for Single against computer, or 'm' for Multiplayer against another person:");
            string userInput = Console.ReadLine();
            /*//return userInput;*/

            player1 = new Human();
            if (userInput == "s")
            {

                player2 = new Computer();
            }
            else if (userInput == "m")
            {
                player2 = new Human();
            }
            else
            {
                ChooseGameMode();
            }
        }
        //Console.ReadLine();

        // userChosenGesture
        public void SetGesture()
        {
            Console.WriteLine("List of options to choose from:");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            Console.WriteLine("4) Lizard");
            Console.WriteLine("5) Spock");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose: Rock");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("You chose: Paper");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You chose: Scissors");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("You chose: Lizard");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("You chose: Spock");
                    Console.ReadLine();
                    break;
            }

            //Console.ReadLine();
            // COMPUTER RANDOMLY SELECTING 
            var random = new Random();
            {
                var list = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                int index = random.Next(list.Count);
                Console.WriteLine("Computer chose: " + list[index]);
            }
            Console.ReadLine();

            /*public void RunGame()      // This underlined public is coming up as invalid & for hours I haven't figured out why. Ahhhhh! It keeps telling me to delete this section, but NO I WON'T!
            {
                GameplayRules();
                ChooseGameMode();
                SetGesture();
            }*/
        }
    }
}
