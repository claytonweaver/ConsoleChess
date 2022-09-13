using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Models;
using ConsoleChess.Screen;

namespace ConsoleChess.Screens
{
    public class MainScreen : IScreen
    {
        private readonly ScreenMode _screenMode;
        private readonly GameScreen _gameScreen;
        private readonly StartMenuScreen _startMenuScreen;
        private readonly Board _board;

        public MainScreen(Board board)
        {
            _board = board;
            _screenMode = ScreenMode.StartMenu;
            _gameScreen = new GameScreen();
            _startMenuScreen = new StartMenuScreen();
        }

        public void Print()
        {
            PrintUtils.PrintHorizontalLine();

            if (_screenMode == ScreenMode.StartMenu)
            {
                _startMenuScreen.Print();
            }
            else
            {
                _gameScreen.Print();
            }

            PrintUtils.PrintHorizontalLine();
        }
    }
}