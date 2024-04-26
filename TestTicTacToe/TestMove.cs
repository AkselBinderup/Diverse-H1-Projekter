using KryssAndBall.Functionalities;

namespace TestTicTacToe;

public class TestMove
{
    [Fact]
    public void UnitTestMoveFirstFive() { 
        Move move = new Move();
        char[,] board = new char[3, 3];
        char player = 'x';
        int turns = 3;
        bool robot = false;

        move.MakeMove(board, player, turns, robot);

        Assert.Equal(player, board[0, 0]);
    }
    [Fact]
    public void MakeMove_First5TurnsWithRobot_MoveMadeCorrectly()
    {
        // Arrange
        Move move = new Move();
        char[,] board = new char[3, 3];
        char player = 'x';
        int turns = 3;
        bool robot = true;

        // Act
        move.MakeMove(board, player, turns, robot);

        // Assert
        // Add assertions to ensure the move is made correctly
        // For example:
        Assert.NotEqual(' ', board[0, 0]);
    }

    [Fact]
    public void MakeMove_AfterFirst5TurnsWithoutRobot_MoveMadeCorrectly()
    {
        // Arrange
        Move move = new Move();
        char[,] board = new char[3, 3] { { 'x', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        char player = 'x';
        int turns = 6;
        bool robot = false;

        // Act
        move.MakeMove(board, player, turns, robot);

        // Assert
        // Add assertions to ensure the move is made correctly
        // For example:
        Assert.Equal(player, board[0, 1]);
    }

    [Fact]
    public void MakeMove_AfterFirst5TurnsWithRobot_MoveMadeCorrectly()
    {
        // Arrange
        Move move = new Move();
        char[,] board = new char[3, 3] { { 'x', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        char player = 'x';
        int turns = 6;
        bool robot = true;

        // Act
        move.MakeMove(board, player, turns, robot);

        // Assert
        // Add assertions to ensure the move is made correctly
        // For example:
        Assert.NotEqual(' ', board[1, 1]);
    }
}
