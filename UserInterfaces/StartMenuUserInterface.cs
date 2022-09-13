using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Screens;

namespace ConsoleChess.UserInterfaces
{
    public class StartMenuUserInterface : UserInterface, IUserInterface
    {
        private readonly StartMenuScreen _screen;
        public StartMenuUserInterface(StartMenuScreen screen)
        {
            _screen = screen;
        }

        public override bool IsActive { get; set; } = false;

        public override bool IsValidInput(string? userInput)
        {
            return !string.IsNullOrEmpty(userInput) && (userInput.ToLower() == "1" || userInput.ToLower() == "2");
        }

        public override void Print()
        {
            _screen.Print();
        }

        public override void PrintUserError(string? userInput)
        {
            _screen.PrintUserInputError(userInput);
        }
    }
}