using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            while (true)
            {
                Console.WriteLine("Enter Player Name: ");
                player.Name = Console.ReadLine();
                Console.WriteLine("Enter Player DayScienceLastLogin: ");
                player.DaysSinceLastLogin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Player DOB: ");
                player.DateOfBrith = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Player Experience: ");
                player.IsNoob = Convert.ToBoolean(Console.ReadLine());

                player.Print();
            }
        }
    }
}
