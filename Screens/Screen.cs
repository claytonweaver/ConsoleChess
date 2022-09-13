using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Screens
{
    public abstract class Screen
    {
        public void PrintUserInputError(string? userInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Input '{userInput}' is not valid. Please try again.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}