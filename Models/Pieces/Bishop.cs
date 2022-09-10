using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public class Bishop : Piece
    {
        public override IEnumerable<(int, int)> GetMoveRange() => new List<(int, int)>
        {
            (1, 1),
            (2, 2),
            (3, 3),
            (4, 4),
            (5, 5),
            (6, 6),
            (7, 7),
            (8, 8),
            (-1, -1),
            (-2, -2),
            (-3, -3),
            (-4, -4),
            (-5, -5),
            (-6, -6),
            (-7, -7),
            (-8, -8),
        };
    }
}