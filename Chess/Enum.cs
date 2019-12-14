using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Enum
    {
        public enum PlayerType
        {
            Human = 0,
            CPU = 1
        }

        public enum Color
        {
            White = 0,
            Black = 1
        }

        public enum GameStatus
        {
            ACTIVE,
            BLACK_WIN,
            WHITE_WIN,
            FORFEIT,
            STALEMATE,
            RESIGNATION
        }
    }
}
