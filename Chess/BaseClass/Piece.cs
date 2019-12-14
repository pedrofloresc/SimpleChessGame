﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.BaseClass
{
    public abstract class Piece 
    {
        protected Piece(bool isWhite, bool isKilled)
        {
            IsWhite = isWhite;
            IsKilled = isKilled;
        }

        public bool IsWhite { get; set; }
        public bool IsKilled { get; set; }
    }
}
