using Chess.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Spot: IEnumerable
    {
        
        public Spot(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        public int CoordinateX;
        public int CoordinateY;
        public Piece piece;

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
