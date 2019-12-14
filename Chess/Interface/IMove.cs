using Chess.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Interface
{
    public interface IMove
    {
        bool Move(Piece piece, int startX, int startY, int endX, int endY);
    }
}
