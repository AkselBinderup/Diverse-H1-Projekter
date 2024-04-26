using KryssAndBall.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KryssAndBall.Validation
{
    public class GameStatus
    {
        public bool IsWinner(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (IsEqual(board[i, 0], board[i, 1], board[i, 2]) 
                || IsEqual(board[0, i], board[1, i], board[2, i]))
                { 
                    return true; 
                }
            }
            if (IsEqual(board[0, 0], board[1, 1], board[2, 2]) 
            || IsEqual(board[2, 0], board[1, 1], board[0, 2]))
            { 
                return true; 
            }
            return false;
        }
        private bool IsEqual(char first, char second, char third)
        => first == second && second == third && first != ' ';
        public void GameEnded(char[,] boardArray, char player)
        {
            Console.Clear();
            Board board = new Board();
            board.PrintBoard(boardArray);
            Console.WriteLine($"{player} vandt!");
        }
    }
}
    