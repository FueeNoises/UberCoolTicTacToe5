using System;
using System.Collections.Generic;
using System.Text;

namespace UberCoolTicTacToe5
{
    class Game
    {
        public bool gameEnd = true;
        List<char> board = new List<char>();
        char playerA = 'X';
        char playerB = 'O';
        enum State { TurnA, TurnB };
        State state = State.TurnA;


        static void Main(string[] args)
        {
            Game game = new Game();
            game.Init();
            while (!game.gameEnd)
            {
                game.ShowBoard();
                game.GetMove();
                game.CheckForWinner();
            }

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        void Init()
        {
            //krjgehbhavn
        }

        void ShowBoard()
        {

        }

        void GetMove()
        {

        }

        void CheckForWinner()
        {
        }
    }
}
