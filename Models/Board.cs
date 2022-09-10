using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleChess.Models.Pieces;

namespace ConsoleChess.Models
{
    public class Board
    {
        public Dictionary<Piece, (int positionX, int positionY)> Pieces { get; set; } = new Dictionary<Piece, (int, int)>();

        public Board()
        {
            SetBoard();
        }

        private void SetBoard()
        {
            //pieces with intiial x, y positions

            for (int i = 0; i < 7; i++)
            {
                Pieces.Add(new Pawn { IsWhite = true }, (i, 1));
                Pieces.Add(new Pawn { IsWhite = false }, (i, 7));
            }

            Pieces.Add(new Rook { IsWhite = true }, (0, 0));
            Pieces.Add(new Rook { IsWhite = true }, (7, 0));
            Pieces.Add(new Rook { IsWhite = false }, (7, 7));
            Pieces.Add(new Rook { IsWhite = false }, (0, 7));

            Pieces.Add(new Knight { IsWhite = true }, (1, 1));
            Pieces.Add(new Knight { IsWhite = true }, (6, 0));
            Pieces.Add(new Knight { IsWhite = false }, (6, 6));
            Pieces.Add(new Knight { IsWhite = false }, (0, 6));

            Pieces.Add(new Bishop { IsWhite = true }, (2, 0));
            Pieces.Add(new Bishop { IsWhite = true }, (5, 0));
            Pieces.Add(new Bishop { IsWhite = false }, (5, 7));
            Pieces.Add(new Bishop { IsWhite = false }, (2, 7));

            Pieces.Add(new King { IsWhite = true }, (4, 0));
            Pieces.Add(new King { IsWhite = false }, (4, 7));

            Pieces.Add(new Queen { IsWhite = true }, (3, 0));
            Pieces.Add(new Queen { IsWhite = false }, (3, 7));
        }
    }
}