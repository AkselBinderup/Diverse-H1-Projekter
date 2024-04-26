using KryssAndBall.Validation;

namespace TestTicTacToe
{
    public class TestKryssAndBall
    {
        GameStatus gameStatus = new GameStatus();
        [Fact]
        public void UnitTestValidationGameWon()
        {
            char[,] a = new char[3, 3] { { 'x', 'x', 'x' }, { 'o', 'o', ' ' }, { ' ', ' ', ' ' } };
            char[,] b = new char[3, 3] { { 'x', ' ', 'x' }, { 'o', 'o', ' ' }, { ' ', ' ', ' ' } };
            Assert.True(gameStatus.IsWinner(a));
            Assert.False(gameStatus.IsWinner(b));
        }
        [Fact]
        public void UnitTestValidationGameEnded()
        {
            char player = 'o';
            char[,] a = new char[3, 3] { { 'x', 'x', 'x' }, { 'o', 'o', ' ' }, { ' ', ' ', ' ' } };
            char[,] b = new char[3, 3] { { 'x', ' ', 'x' }, { 'o', 'o', ' ' }, { ' ', ' ', ' ' } };

            
        }

    }
}