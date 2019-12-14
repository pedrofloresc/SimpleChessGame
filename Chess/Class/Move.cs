using Chess.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Move
    {
        public Player Player { get; private set; }
        public Spot Start { get; private set; }
        public Spot End { get; private set; }
        public Piece PieceMoved { get; private set; }
        public Piece PieceKilled { get; private set; }

        public Move(Player player, Spot start, Spot end)
        {
            this.Player = player;
            this.Start = start;
            this.End = end;
            this.PieceMoved = start.piece;
            this.PieceKilled = end.piece;
        }
         
    }
}
