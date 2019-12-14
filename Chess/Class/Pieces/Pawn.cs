using Chess.BaseClass;
using Chess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{

    public class Pawn : Piece
    {
        public Pawn(bool isWhite, bool isKilled) : base(isWhite, isKilled)
        {
        }

        public override bool CanMove(Board board, Spot start, Spot end)
        {
            var iniSpot = board.spots[start.CoordinateX][start.CoordinateY];
            var endSpot = board.spots[end.CoordinateX][end.CoordinateY];

            if(endSpot.piece != null)
            {
                return false;
            }
            else if(iniSpot.CoordinateY == endSpot.CoordinateY 
                && endSpot.CoordinateX - iniSpot.CoordinateX == 1
                && true //need to evaluate direction 
                )
            {
                return true;
            }
            //eat
            else if(iniSpot.CoordinateY + 1 == endSpot.CoordinateY 
                && iniSpot.CoordinateX + 1 == endSpot.CoordinateX // right lower diagonal
            || true //left lower diagonal
            || true //right upper diagonal
            || true) // left upper diagonal
                {

            }

            return false;
        }
    }
}
