using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Screens
{
    public class StartMenuScreen : Screen, IScreen
    {
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Console Chess!");
            Console.WriteLine();
            Console.WriteLine("Select an option:");
            Console.WriteLine();
            Console.WriteLine("(1): Play Chess");
            Console.WriteLine("(2): Quit");
            Console.WriteLine();
        }
    }
}