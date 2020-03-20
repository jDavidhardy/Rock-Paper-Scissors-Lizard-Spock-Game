using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{
    class Computer: Player
    {
        public override void SetGesture()
        {
            // COMPUTER RANDOMLY SELECTING 
            var random = new Random();
            {
                var list = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                int index = random.Next(list.Count);
                Console.WriteLine("Johnny 5 chose: " + list[index]);
            }
            Console.ReadLine();

        }
        public override void SetName()
        {
            name = "Johnny 5";
        }
    }
}
