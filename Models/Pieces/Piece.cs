using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public abstract class Piece
    {
        public bool IsWhite { get; set; } = false;
        public abstract IEnumerable<(int x, int y)> GetMoveRange();
    }
}