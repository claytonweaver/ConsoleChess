using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Screens;

namespace ConsoleChess.UserInterfaces
{
    public class TurnUserInterface : UserInterface, IUserInterface
    {
        private readonly TurnScreen _turnScreen;
        public TurnUserInterface(TurnScreen turnScreen)
        {
            _turnScreen = turnScreen;
        }

        public override bool IsActive { get; set; } = false;

        public override void Print()
        {
            _turnScreen.Print();
        }

        public override void PrintUserError(string? userInput)
        {
            _turnScreen.PrintUserInputError(userInput);
        }
    }
}