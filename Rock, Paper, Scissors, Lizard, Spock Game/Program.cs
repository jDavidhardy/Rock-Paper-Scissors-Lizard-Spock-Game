﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Gameplay sim = new Gameplay();
            //sim.RunGame();
            sim.GameplayRules();
            sim.ChooseGameMode();
            sim.SetGesture();
        }
    }
}
