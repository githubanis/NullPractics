using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GameConsole
{
    static class PlayerDisplay
    {
        public static void Print(this PlayerCharacter player)
        {
            int dsll = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            if (string.IsNullOrEmpty(player.Name)) Console.WriteLine("Name Not Specified"); else Console.WriteLine(player.Name);
            Console.WriteLine(dsll);
            if (player.DateOfBrith == null) Console.WriteLine("DateOfBirth Not Specified"); else Console.WriteLine(player.DateOfBrith);
            if (player.IsNoob == null) Console.WriteLine("Unknown"); else if (player.IsNoob == true) Console.WriteLine("Player is newbe"); else Console.WriteLine("Experienced Player");
        }
    }
}
