using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public class Rook : Piece
    {

        public override IEnumerable<(int, int)> GetMoveRange() => new List<(int, int)>
        {
            (1, 0),
            (2, 0),
            (3, 0),
            (4, 0),
            (5, 0),
            (6, 0),
            (7, 0),
            (0, 1),
            (0, 2),
            (0, 3),
            (0, 4),
            (0, 5),
            (0, 6),
            (0, 7),
            (0, 8),
            (-1, 0),
            (-2, 0),
            (-3, 0),
            (-4, 0),
            (-5, 0),
            (-6, 0),
            (-7, 0),
            (0, -1),
            (0, -2),
            (0, -3),
            (0, -4),
            (0, -5),
            (0, -6),
            (0, -7),
            (0, -8),
        };
    }
}