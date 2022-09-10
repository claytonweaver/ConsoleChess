using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleChess.Models.Pieces
{
    public class Pawn : Piece
    {
        public bool FirstMove { get; set; } = true;
        public override IEnumerable<(int, int)> GetMoveRange()
        {
            return FirstMove ? new List<(int, int)> { (2, 0) } : new List<(int, int)> { (1, 0) };
        }
    }
}