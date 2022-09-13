using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Screens;
using ConsoleChess.UserInterfaces;

namespace ConsoleChess
{
    public class UserInterfaceManager
    {
        private List<UserInterface> _userInterfaces = new List<UserInterface>();

        public UserInterfaceManager()
        {
            var startMenuScreen = new StartMenuScreen();
            var startMenuInterface = new StartMenuUserInterface(startMenuScreen);

            _userInterfaces.Add(startMenuInterface);
        }
    }
}