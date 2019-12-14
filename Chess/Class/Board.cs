using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Board
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
                    this.spots[pawnRow][i] = new Spot();
                    this.spots[pawnRow][i].piece = pawn;
                }

                int piecesPosition = 0;
                if (color == Enum.Color.Black)
                    piecesPosition = 7;
                //setting tower

                List<int> listRookYPosition = new List<int>() { 0, 7 };

                foreach (var rookYPosition in listRookYPosition)
                {
                    this.spots[piecesPosition][rookYPosition] = new Spot();
                    this.spots[piecesPosition][rookYPosition].piece = new Rook(color == Enum.Color.White, false);
                }


                //setting knight
                List<int> listKnightYPosition = new List<int>() { 1, 6 };

                foreach (var knightYPosition in listKnightYPosition)
                {
                    this.spots[piecesPosition][knightYPosition] = new Spot();
                    this.spots[piecesPosition][knightYPosition].piece = new Knight(color == Enum.Color.White, false); ;
                }

                //setting bishop
                List<int> listBishopYPosition = new List<int>() { 2, 5 };

                foreach (var bishopYPosition in listBishopYPosition)
                {
                    this.spots[piecesPosition][bishopYPosition] = new Spot();
                    this.spots[piecesPosition][bishopYPosition].piece = new Bishop(color == Enum.Color.White, false); ;
                }

                //setting queen
                int queenYPosition = 4;

                this.spots[piecesPosition][queenYPosition] = new Spot();
                this.spots[piecesPosition][queenYPosition].piece = new Queen(color == Enum.Color.White, false); ;

                //setting king
                int kingYPosition = 3;

                this.spots[piecesPosition][kingYPosition] = new Spot();
                this.spots[piecesPosition][kingYPosition].piece = new King(color == Enum.Color.White, false); ;

            }

            List<int> listMiddleBlank = new List<int> { 2, 3, 4, 5 };

            foreach (var middleBlank in listMiddleBlank)
            {
                for (int i = 0; i < Size; i++)
                {
                    this.spots[middleBlank][i] = new Spot();
                }
            }
        }
    }
}
