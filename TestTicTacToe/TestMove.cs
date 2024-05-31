using Xunit;
using KryssAndBall.Functionalities;

namespace TestTicTacToe
{
    public class TestMove
    {
        [Fact]
        public void UnitTestMoveFirstFive()
        {
            MoveTest move = new MoveTest();
            char[,] board = new char[3, 3];
            int row = 1, col = 2;
            char player = 'x';
            int turns = 3;
            bool robot = false;

            bool result = move.MakeMove(board, player, turns, robot, row, col);

            Assert.True(result);
            Assert.Equal(player, board[row, col]);
        }

        [Fact]
        public void UnitTestRobotMoves()
        {
            MoveTest move = new MoveTest();
            char[,] board = new char[3, 3];
            char player = 'x';
            int turns = 3;
            bool robot = true;

            bool result = move.MakeMove(board, player, turns, robot, 0, 0); 

            Assert.True(result);
            Assert.NotEqual(' ', board[0, 0]);
        }

        [Fact]
        public void UnitTestMovesWithoutRobot()
        {
            MoveTest move = new MoveTest();
            char[,] board = new char[3, 3] { { 'x', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            char player = 'x';
            int turns = 6;
            bool robot = false;

            bool result = move.MakeMove(board, player, turns, robot, 0, 1); 

            Assert.True(result);
            Assert.Equal(player, board[0, 1]);
        }

        [Fact]
        public void TestMoveMadecorrectly()
        {
            MoveTest move = new MoveTest();
            char[,] board = new char[3, 3] { { 'x', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            char player = 'x';
            int turns = 6;
            bool robot = true;

            bool result = move.MakeMove(board, player, turns, robot, 1, 1); 

           
            Assert.True(result);
            Assert.NotEqual(' ', board[1, 1]);
        }
    }
}