using System;
using System.Threading.Tasks.Dataflow;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new PlayerDisplay();
            var a = new PlayerCharacter();
            p.Write(a);
        }
    }
}
