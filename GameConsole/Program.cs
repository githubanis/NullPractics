﻿using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "    Anis  ";
            player.Name.Trim();
            player.DaysSinceLastLogin = 23;
            player.DateOfBrith = DateTime.Today;
            player.IsNoob = true;

            player.Print();

        }
    }
}
