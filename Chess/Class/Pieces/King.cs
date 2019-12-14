using Chess.BaseClass;
using Chess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class King : Piece
    {
        public King(bool isWhite, bool isKilled) : base(isWhite, isKilled)
        {
        }

        public override bool CanMove(Board board, Spot start, Spot End)
        {
            throw new NotImplementedException();
        }
         
    }
}
