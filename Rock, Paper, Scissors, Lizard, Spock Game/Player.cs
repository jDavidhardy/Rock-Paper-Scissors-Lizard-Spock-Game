using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{
    class Player
    {
        // member variables (HAS A)
        public List<string> gesture;



        //constructor {ENTER ctor tab tab to get template}
        public Player()
        {
            gesture = new List<string>();

       /*     Human input1 = new Human("Rock");
            Human input2 = new Human("Paper");
            Human input3 = new Human("Scissors");
            Human input4 = new Human("Lizard");
            Human input5 = new Human("Spock");
*/
            gesture.Add("Rock");
            gesture.Add("Paper");
            gesture.Add("Scissors");
            gesture.Add("Lizard");
            gesture.Add("Spock");
        }



        // member methods (CAN DO)
    }
}
