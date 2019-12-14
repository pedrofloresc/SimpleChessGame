using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.BaseClass
{
    public abstract class Player
    {
        public Enum.PlayerType PlayerType { get; set; }
        public bool IsWhitePlayer { get; set; }
    }
}
