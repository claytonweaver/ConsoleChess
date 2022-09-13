using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Screens;

namespace ConsoleChess.UserInterfaces
{
    public abstract class UserInterface
    {

        public abstract bool IsActive { get; set; }
        public abstract void Print();
        public abstract void PrintUserError(string? userInput);

        public virtual bool IsValidInput(string? userInput)
        {
            return !string.IsNullOrEmpty(userInput);
        }

        public string GetUserResponse()
        {
            var userInput = "";
            var userInputIsValid = false;
            while (!userInputIsValid)
            {
                Print();
                userInput = Console.ReadLine();
                userInputIsValid = IsValidInput(userInput);
                if (!userInputIsValid)
                {
                    PrintUserError(userInput);
                }
            }

            return userInput!;
        }
    }
}