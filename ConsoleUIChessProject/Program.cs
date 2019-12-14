using Chess.BaseClass;
using Chess.Class;
using System;

namespace ConsoleUIChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new HumanPlayer();
            player1.IsWhitePlayer = true;
            player1.PlayerType = Chess.Enum.PlayerType.Human;

            Player player2 = new HumanPlayer();
            player2.IsWhitePlayer = false;
            player2.PlayerType = Chess.Enum.PlayerType.Human;

            Game game = new Game(player1, player2);

            bool Exit = false;
            Console.WriteLine("Welcome to chess console game");
            Chess.Enum.Color playersTurn = Chess.Enum.Color.White;
            do
            {

                if (!game.CurrentPlayerTurn.IsWhitePlayer)
                    playersTurn = Chess.Enum.Color.Black;
                Console.WriteLine(playersTurn.ToString() + " Player turn!!");
                Console.WriteLine("Menu:");
                Console.WriteLine("type: 1 to Exit");
                Console.WriteLine("");

                var key = Console.ReadKey();

                switch (key.Key.ToString())
                {
                    case "D1":
                    case "Numpad1":
                        Exit = true;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("You Pressed: " + key.Key);


                Console.WriteLine(game.Move(game.Player1, 0, 0, 1, 1));
            }
            while (game.GameStatus == Chess.Enum.GameStatus.ACTIVE && !Exit);
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }
    }
}
