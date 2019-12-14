using Chess.BaseClass;
using Chess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class King : Piece, IMove
    {
        public King(bool isWhite, bool isKilled) : base(isWhite, isKilled)
        {
        }

        public bool Move(Pierce piece, int startX, int startY, int endX, int endY)
        {
            throw new NotImplementedException();
        }
    }
}
