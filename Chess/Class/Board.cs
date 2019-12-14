using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Board: IEnumerable
    {
        public Spot[][] spots;
        public int Size { get; private set; }
        public Board(int size)
        {
            Size = size;
            spots = new Spot[Size][];
            for (int i = 0; i < Size; i++)
            {
                spots[i] = new Spot[Size];
            }
            Reset();
        }

        public void Reset()
        {
            Initiliaze();

        }

        private void Initiliaze()
        {
            foreach (Enum.Color color in System.Enum.GetValues(typeof(Enum.Color)))
            {
                //setting pawns
                for (int i = 0; i < Size; i++)
                {
                    Pawn pawn = new Pawn(color == Enum.Color.White, false);

                    int pawnRow;
                    if (color == Enum.Color.White)
                        pawnRow = 1;
                    else
                        pawnRow = 6;
                    this.spots[pawnRow][i] = new Spot(pawnRow, i);
                    this.spots[pawnRow][i].piece = pawn;
                }

                int piecesPositionX = 0;
                if (color == Enum.Color.Black)
                    piecesPositionX = 7;
                //setting tower

                List<int> listRookPositionY = new List<int>() { 0, 7 };

                foreach (var rookPositionY in listRookPositionY)
                {
                    this.spots[piecesPositionX][rookPositionY] = new Spot(piecesPositionX, rookPositionY);
                    this.spots[piecesPositionX][rookPositionY].piece = new Rook(color == Enum.Color.White, false);
                }


                //setting knight
                List<int> listKnightPositionY = new List<int>() { 1, 6 };

                foreach (var knightPositionY in listKnightPositionY)
                {
                    this.spots[piecesPositionX][knightPositionY] = new Spot(piecesPositionX, knightPositionY);
                    this.spots[piecesPositionX][knightPositionY].piece = new Knight(color == Enum.Color.White, false); ;
                }

                //setting bishop
                List<int> listBishopPositionY = new List<int>() { 2, 5 };

                foreach (var bishopPositionY in listBishopPositionY)
                {
                    this.spots[piecesPositionX][bishopPositionY] = new Spot(piecesPositionX, bishopPositionY);
                    this.spots[piecesPositionX][bishopPositionY].piece = new Bishop(color == Enum.Color.White, false); ;
                }

                //setting queen
                int queenPositionY = 4;

                this.spots[piecesPositionX][queenPositionY] = new Spot(piecesPositionX, queenPositionY);
                this.spots[piecesPositionX][queenPositionY].piece = new Queen(color == Enum.Color.White, false); ;

                //setting king
                int kingPositionY = 3;

                this.spots[piecesPositionX][kingPositionY] = new Spot(piecesPositionX, kingPositionY);
                this.spots[piecesPositionX][kingPositionY].piece = new King(color == Enum.Color.White, false); ;

            }

            List<int> listMiddleBlank = new List<int> { 2, 3, 4, 5 };

            foreach (var middleBlank in listMiddleBlank)
            {
                for (int i = 0; i < Size; i++)
                {
                    this.spots[middleBlank][i] = new Spot(middleBlank,i);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if(spots[i][j].piece != null)
                        yield return spots[i][j].piece.GetType().Name;
                }
            }
           
        }
    }
}
