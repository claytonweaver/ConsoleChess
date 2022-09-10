using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public class Knight : Piece
    {
        public override IEnumerable<(int, int)> GetMoveRange() => new List<(int, int)>
        {
            (1, 2),
            (-1, 2),
            (1, -2),
            (-1, -2)
        };
    }
}