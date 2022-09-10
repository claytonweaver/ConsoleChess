using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models
{
    public class Game
    {
        public Board Board { get; set; } = new Board();
    }
}