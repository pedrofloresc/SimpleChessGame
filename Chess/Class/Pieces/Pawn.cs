using Chess.BaseClass;
using Chess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Pawn : Piece, IMove
    {
        public Pawn(bool isWhite, bool isKilled) : base(isWhite, isKilled)
        {
        }

        public bool Move(Pierce piece, int startX, int startY, int endX, int endY)
        {
            if (this.IsKilled)
                return false;
            if (startX < 0 || startY < 0 || endX < 0 || endY < 0)
                return false;

            return true;
        }
    }
}
