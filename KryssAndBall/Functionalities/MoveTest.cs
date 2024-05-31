using KryssAndBall.Graphics;
using System;

namespace KryssAndBall.Functionalities
{
    public class MoveTest
    {
        private Random random = new Random();
        private Board brd = new Board();

        public bool MakeMove(char[,] board, char player, int turns, bool robot, int row, int column)
        {
            try
            {
                ChosenMove(board, player, turns, robot, ref row, ref column);
                if (IsValidMove(row, column, board, player, turns, robot))
                {
                    UpdateBoard(board, player, row, column, turns, robot);
                    return true;
                }
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void ChosenMove(char[,] board, char player, int turns, bool robot, ref int row, ref int column)
        {
            if (robot && player == 'x' || !robot)
            {
                row = row;
                column = column;
            }
            else if (robot && player == 'o')
            {
                row = random.Next(0, 3);
                column = random.Next(0, 3);
            }
        }

        public bool IsValidMove(int row, int column, char[,] board, char player, int turns, bool robot)
        {
            if (row < 0 || column < 0 || row > 2 || row > 2)
            {
                if (robot && player == 'x' || !robot)
                {
                    Console.WriteLine("Ikke godkendt nummer, uden for banen... ");
                }
                return false;
            }

            if (turns < 6 && board[row, column] != ' ')
            {
                if (robot && player == 'x' || !robot)
                {
                    Console.WriteLine("Ikke godkendt træk, plads allerede optaget... ");
                }
                return false;
            }

            return true;
        }

        public void UpdateBoard(char[,] board, char player, int row, int column, int turns, bool robot)
        {
            if (turns >= 6)
            {
                if (board[row, column] != player)
                {
                    if (robot && player == 'x' || !robot)
                    {
                        Console.WriteLine("Du kan kun erstatte dine egne brikker... ");
                    }
                    return;
                }

                board[row, column] = ' ';

                if (robot && player == 'x' || !robot)
                {
                    Console.WriteLine("Vælg brik du vil flytte: ");
                    Console.WriteLine($"[{player}] - Skriv ny række (1-3): ");
                    row = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine($"[{player}] - Skriv ny kolonne (1-3): ");
                    column = int.Parse(Console.ReadLine()) - 1;
                }
                else if (robot && player == 'o')
                {
                    row = random.Next(0, 3);
                    column = random.Next(0, 3);
                }

                if (row < 0 || column < 0 || row > 2 || row > 2 || board[row, column] != ' ')
                {
                    if (robot && player == 'x' || !robot)
                    {
                        Console.WriteLine("Ikke godkendt nummer, uden for banen... ");
                        board[row + 1, column + 1] = player;
                    }
                    return;
                }
            }

            board[row, column] = player;
        }
    }
}
