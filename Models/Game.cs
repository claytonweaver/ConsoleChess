using ConsoleChess.Screens;
using ConsoleChess.UserInterfaces;

namespace ConsoleChess.Models
{
    public class Game
    {
        private readonly Board _board;
        private readonly StartMenuUserInterface _startMenuUserInterface;

        public Game(Board board)
        {
            _board = board;

            var startMenuScreen = new StartMenuScreen();
            _startMenuUserInterface = new StartMenuUserInterface(startMenuScreen);
        }

        public void Start()
        {
            var startOption = _startMenuUserInterface.GetUserResponse();
        }
    }
}