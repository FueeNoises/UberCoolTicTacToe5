using System;

namespace TicTacToe
{
    class TicTacToe
    {
        static char[,] Board2 = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

        static char playerX = 'X';
        static char playerO = 'O';
        static char player = 'X';
        static string playerChoice;
        static string tryagain;
        static bool win1;
        static bool win2;

        // ADD DIAGONAAL WIN CHECK!!!
        // ADD DIAGONAAL WIN CHECK!!!
        // ADD DIAGONAAL WIN CHECK!!!
        // ADD DIAGONAAL WIN CHECK!!!




        static void Welcome()
        {
            Console.WriteLine("Welcome to TicTacToe!");
        }

        static void CallBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(Board2[x, y]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void PlayerSwitch()
        {
            if (player == playerX)
            {
                player = playerO;
            }
            else player = playerX;
        }

        public static void WinFunction()
        {
            //player x
            if (Board2[0, 0] == playerX && Board2[0, 1] == playerX && Board2[0, 2] == playerX)
            {
                win1 = true;
                GameOver();
            }
            if (Board2[1, 0] == playerX && Board2[1, 1] == playerX && Board2[1, 2] == playerX)
            {
                win1 = true;

                GameOver();
            }
            if (Board2[2, 0] == playerX && Board2[2, 1] == playerX && Board2[2, 2] == playerX)
            {
                win1 = true;

                GameOver();
            }
            if (Board2[0, 0] == playerX && Board2[1, 0] == playerX && Board2[2, 0] == playerX)
            {
                win1 = true;

                GameOver();
            }
            if (Board2[0, 1] == playerX && Board2[1, 1] == playerX && Board2[2, 1] == playerX)
            {
                win1 = true;

                GameOver();
            }
            if (Board2[0, 2] == playerX && Board2[1, 2] == playerX && Board2[2, 2] == playerX)
            {
                win1 = true;

                GameOver();
            }
            //player o
            if (Board2[0, 0] == playerO && Board2[0, 1] == playerO && Board2[0, 2] == playerO)
            {
                GameOver();
            }
            if (Board2[1, 0] == playerO && Board2[1, 1] == playerO && Board2[1, 2] == playerO)
            {
                GameOver();
            }
            if (Board2[2, 0] == playerO && Board2[2, 1] == playerO && Board2[2, 2] == playerO)
            {
                GameOver();
            }
            if (Board2[0, 0] == playerO && Board2[1, 0] == playerO && Board2[2, 0] == playerO)
            {
                GameOver();
            }
            if (Board2[0, 1] == playerO && Board2[1, 1] == playerO && Board2[2, 1] == playerO)
            {
                GameOver();
            }
            if (Board2[0, 2] == playerO && Board2[1, 2] == playerO && Board2[2, 2] == playerO)
            {
                GameOver();
            }

        }

        public static void GameOver()
        {
            Console.WriteLine("Try again? 1. Yes/ 2. No");
            tryagain = Console.ReadLine();
            if (tryagain == "1")
            {
                Main();
            }
            else if (tryagain == "2")
            {
                Console.WriteLine("OK bye");
            }
            else
            {
                Console.WriteLine("Wrong input!");
                GameOver();
            }
        }

        static void InputValue()
        {
            Console.WriteLine("Enter your desired number");
            playerChoice = Console.ReadLine();
            switch (playerChoice)
            {
                case "1":
                    if (Board2[0, 0] == '-')
                    {
                        Board2[0, 0] = player;
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "2":
                    if (Board2[0, 1] == '-')
                    {
                        Board2[0, 1] = player;
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "3":
                    if (Board2[0, 2] == '-')
                    {
                        Board2[0, 2] = player;
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "4":
                    if (Board2[1, 0] == '-')
                    {
                        Board2[1, 0] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "5":
                    if (Board2[1, 1] == '-')
                    {
                        Board2[1, 1] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "6":
                    if (Board2[1, 2] == '-')
                    {
                        Board2[1, 2] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "7":
                    if (Board2[2, 0] == '-')
                    {
                        Board2[2, 0] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "8":
                    if (Board2[2, 1] == '-')
                    {
                        Board2[2, 1] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;
                case "9":
                    if (Board2[2, 2] == '-')
                    {
                        Board2[2, 2] = player;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("That one is already in use!");
                    }
                    break;

            }
        }



        static void Main()
        {
            Welcome();
            while (!win1)
            {

                CallBoard();
                InputValue();
                WinFunction();
                PlayerSwitch();

                if (win1 == true)
                {
                    Console.WriteLine("X wins!");
                    break;
                }
                if (win2 == true)
                {
                    Console.WriteLine("O wins!");
                    break;
                }
            }

        }
    }
}