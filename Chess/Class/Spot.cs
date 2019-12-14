using Chess.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Spot
    {
        
        public Spot(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        public int CoordinateX;
        public int CoordinateY;
        public Piece piece;
         
    }
}
