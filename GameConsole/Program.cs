using System;
using System.Threading.Tasks.Dataflow;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Anis";
            player.DaysSinceLastLogin = 23;

            PlayerDisplay.Write(player);

        }
    }
}
