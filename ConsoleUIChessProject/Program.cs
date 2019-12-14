using Chess.BaseClass;
using Chess.Class;
using System;
using System.Collections.Generic;
using System.Linq;

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
                else
                    playersTurn = Chess.Enum.Color.White;
                Menu(playersTurn);
                var key = Console.ReadKey();

                switch (key.Key.ToString())
                {
                    case "D1":
                    case "Numpad1":
                        Exit = true;
                        break;
                    case "D":
                        game.DisplayBoard();
                        break;
                    case "P":
                        bool PlayExit;
                        do
                        {

                            Console.Write("Enter commands (1 0 2 0 => 1,0 => 2,0), E to exit:");
                            int[] commands = CommandReader(out PlayExit);
                            if (commands != null)
                                Console.WriteLine(game.Move(game.CurrentPlayerTurn, commands[0], commands[1], commands[2], commands[3]));
                            else if(!PlayExit)
                                Console.WriteLine("Wrong commands.");
                        }
                        while (!PlayExit);
                        break;
                    default:
                        break;
                }


            }
            while (game.GameStatus == Chess.Enum.GameStatus.ACTIVE && !Exit);
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }

        private static int[] CommandReader(out bool playExit)
        {
            string commands = Console.ReadLine();
            playExit = false;

            if (commands == "e" || commands == "E")
            {
                playExit = true;
                return null;
            }
            
            string[] arrayCommandsSplitted = commands.Split(' ');

            if (arrayCommandsSplitted.Length != 4)
            {
                return null;
            }

            List<int> listCommands = new List<int>();

            foreach (var command in arrayCommandsSplitted)
                listCommands.Add(Convert.ToInt32(command));

            return listCommands.ToArray();
        }

        private static void Menu(Chess.Enum.Color playersTurn)
        {
            Console.WriteLine(playersTurn.ToString() + " Player turn!!");
            Console.WriteLine("Menu:");
            Console.WriteLine("Type 1 to Exit");
            Console.WriteLine("Type D to DisplayBoard");
            Console.WriteLine("Type P to Play, followed by the coordinates of both,");
            Console.WriteLine(" starting and ending board spots, Example: 1 0 2 0 , this means, 1,0 to 2,0");
            Console.Write(":");
        }
    }
}
