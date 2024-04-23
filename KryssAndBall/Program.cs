using KryssAndBall.Functionalities;
using KryssAndBall.Graphics;
using KryssAndBall.Validation;
using System.Data.Common;

namespace TicTacToe;

internal class Program
{
    static void Main()
    {
        try
        {
            Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occured: {ex.Message}");
        }
    }
    private static void Play()
    {
        char[,] boardArray = Board.board();
        char player = 'o';
        int turns = 0;

        while (!GameStatus.IsWinner(boardArray))
        {
            Console.Clear();
            Board.PrintBoard(boardArray);
            player = player == 'x' ? 'o' : 'x';
            Move move = new Move();
            move.MakeMove(boardArray, player, turns);

            turns++;
        }
        GameStatus.GameEnded(boardArray, player);

        Console.ReadKey();
   
    }
}