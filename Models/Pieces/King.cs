using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public class King : Piece
    {
        public override IEnumerable<(int, int)> GetMoveRange() => new List<(int, int)>
        {
            (1, 0),
            (0, 1),
            (-1, 0),
            (0, -1),
        };
    }
}