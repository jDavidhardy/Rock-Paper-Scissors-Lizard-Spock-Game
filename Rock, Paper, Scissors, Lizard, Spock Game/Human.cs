using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{
    class Human : Player
    {

        public override void SetGesture()
        {
            /*Console.WriteLine("Make a choice");
            choice = Console.ReadLine();
            //switch case good for user validation*/

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

                    Console.ReadLine();
            }
        }
        public override void SetName()
        {
            Console.WriteLine("Choose name");
            string name = Console.ReadLine();
        }

        /* // member variables (HAS A)
         public userInput;
        public Human()
         {

             this.score = 0;
         }
         public override void GestureSelect()
         {
             base.GestureSelect();
         }
         //constructor {ENTER ctor tab tab to get template}
         // member methods (CAN DO)*/

    }
}
