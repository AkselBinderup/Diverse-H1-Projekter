using KryssAndBall.Functionalities;
using KryssAndBall.Graphics;
using KryssAndBall.Validation;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace TicTacToe;

internal class Program
{
    GameStatus gameStatus = new GameStatus();
    static void Main()
    {
        try
        {
            Program program = new Program();
            Console.WriteLine("Kryds og bolle:\nTryk på en knap for at starte...");
            Console.ReadKey();
            Console.WriteLine("Vil du spille mod computer? [ja/nej]");
            bool robot = Console.ReadLine().ToLower() == "ja";
            program.Play(robot);
        } 
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occured: {ex.Message}");
        }
    }
    private void Play(bool robot)
    {
        Board brd = new Board();
        brd.board();
        char[,] boardArray = brd.chars;
        char player = 'o'; 
        int turns = 0;

        while (!gameStatus.IsWinner(boardArray))
        {
            Console.Clear();
            brd.PrintBoard(boardArray);
            player = player == 'x' ? 'o' : 'x';
            Move move = new Move();
            move.MakeMove(boardArray, player, turns, robot);
            turns++;
        }
        gameStatus.GameEnded(boardArray, player);
        Console.ReadKey();
   
    }
}