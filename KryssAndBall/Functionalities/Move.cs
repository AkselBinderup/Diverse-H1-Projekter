using KryssAndBall.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KryssAndBall.Functionalities;

internal class Move
{
    internal int resetTurns { get; set; }
    internal void MakeMove(char[,] board, char xo, int turns)
    {

        while (true)
        {
            try
            {
                Console.Clear();
                resetTurns = turns;
                if (turns < 6)
                    Console.WriteLine("Make a move:");
                else
                    Console.WriteLine("Choose which piece to replace:");

                Board.PrintBoard(board);


                Console.WriteLine($"[{xo}] - Enter row (1-3): ");
                int row = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine($"[{xo}] - Enter column (1-3): ");
                int column = int.Parse(Console.ReadLine()) - 1;
                if (row < 0 || column < 0 || row > 2 || row > 2)
                {
                    Console.WriteLine("Out of bounds... ");
                    Thread.Sleep(2000);
                    continue;
                }

                if (turns < 6 && board[row, column] != ' ')
                {
                    Console.WriteLine("Not valid, position already taken... ");
                    Thread.Sleep(2000);
                    continue;
                }

                if (turns >= 6)
                {
                    if (board[row, column] != xo)
                    {
                        Console.WriteLine("You can only replace your own pieces... ");
                        Thread.Sleep(2000);
                        continue;
                    }

                    board[row, column] = ' ';
                    Console.WriteLine("Chose whice piece to replace: ");
                    Console.WriteLine($"[{xo}] - Enter new row (1-3): ");
                    row = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine($"[{xo}] - Enter new column (1-3): ");
                    column = int.Parse(Console.ReadLine()) - 1;

                    if (row < 0 || column < 0 || row > 2 || row > 2 || board[row, column] != ' ')
                    {
                        Console.WriteLine("Out of bounds...");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                board[row, column] = xo;
                break;
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(2000);
            }
        }
    }

}

