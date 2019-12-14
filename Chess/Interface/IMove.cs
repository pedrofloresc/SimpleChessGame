using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Interface
{
    public interface IMove
    {
        bool Move(Pierce piece, int startX, int startY, int endX, int endY);
    }
}
