using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplay
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin == -1)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBrith == DateTime.MinValue)
            {

            }
        }
    }
}
