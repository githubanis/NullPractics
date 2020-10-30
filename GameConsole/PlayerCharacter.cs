using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBrith = DateTime.MinValue;    //--> magic number
            DaysSinceLastLogin = -1;            //--> magic number
        }
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBrith { get; set; }
    }
}
