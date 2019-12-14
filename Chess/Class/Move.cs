using Chess.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Move
    {
        private Player player;
        private Spot start;
        private Spot end;
        private Piece pieceMoved;
        private Piece pieceKilled;

        public Move(Player player, Spot start, Spot end)
        {
            this.player = player;
            this.start = start;
            this.end = end;
            this.pieceMoved = start.piece;
        }
         
    }
}
