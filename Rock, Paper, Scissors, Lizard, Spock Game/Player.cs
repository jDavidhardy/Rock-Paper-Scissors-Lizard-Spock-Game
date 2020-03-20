using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{

    public abstract class Player
    {
        public string name;
        public string choice;
        public int score;
        public List<string> gestures;
        public Player()
        {
            gestures = new List<string>();

            /*     Human input1 = new Human("Rock");
                Human input2 = new Human("Paper");
                Human input3 = new Human("Scissors");
                Human input4 = new Human("Lizard");
                Human input5 = new Human("Spock");
           */
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

        }

        public abstract void SetGesture();


        public abstract void SetName();
    }
}

