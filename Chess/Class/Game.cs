﻿using Chess.BaseClass;
using Chess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Class
{
    public class Game
    {
        public Game(Player player1, Player player2)
        {
            if ((player1.IsWhitePlayer != true && player2.IsWhitePlayer != true)
                || (player1.IsWhitePlayer != false && player2.IsWhitePlayer != false)
                )
                throw new Exception("Error: I need one player to be white and the other black");

            Board = new Board(8);
            Player1 = player1;
            Player2 = player2;
            if (player1.IsWhitePlayer == true)
                CurrentPlayerTurn = Player1;
            else
                CurrentPlayerTurn = Player2;
            GameStatus = Enum.GameStatus.ACTIVE;
            Moves = new List<Move>();
        }

        public string Move(Player player, int startX, int startY, int endX, int endY)
        {
            if (GameStatus != Enum.GameStatus.ACTIVE)
                return "The game is inactive, Status: " + GameStatus.ToString(); 
            else if (player != CurrentPlayerTurn)
                return "Is not your turn!!";


            this.ChangeTurn();

            return CurrentPlayerTurn.IsWhitePlayer == true ? "White player turn!." : "Black playr turn!";
        }

        private void ChangeTurn()
        {
            if (CurrentPlayerTurn == Player1)
                CurrentPlayerTurn = Player2;
            else
                CurrentPlayerTurn = Player1;
        }

        public Board Board { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player CurrentPlayerTurn { get; private set; }

        public List<Move> Moves {get ;set;}
        public Enum.GameStatus GameStatus { get; set; }

        
    }
}