using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryssAndBall.Graphics;

internal class Board
{
    internal static char[,] board()
    {
        char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        PrintBoard(board);
        return board;
    }

    internal static void PrintBoard(char[,] boardPos)
    {
        Console.WriteLine("  1 | 2 | 3 ");
        Console.WriteLine($"1 {boardPos[0,0]} | {boardPos[0, 1]} | {boardPos[0, 2]}");
        Console.WriteLine(" ---|---|---");
        Console.WriteLine($"2 {boardPos[1, 0]} | {boardPos[1, 1]} | {boardPos[1, 2]}");
        Console.WriteLine(" ---|---|---");
        Console.WriteLine($"3 {boardPos[2, 0]} | {boardPos[2, 1]} | {boardPos[2, 2]}");
    }
}
