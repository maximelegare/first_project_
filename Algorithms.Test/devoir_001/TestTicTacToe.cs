using Algorithms.devoir_001;

namespace Algorithms.Test;

[TestClass]
public class TestTicTacToe
{
    [TestMethod]
    public void TestPiEstimate()
    {
       TicTacToe ticTacToe = new TicTacToe();
        ticTacToe.xPlay(0, 0);
        ticTacToe.oPlay(1, 2);
        ticTacToe.xPlay(2, 1);
        ticTacToe.oPlay(2, 2);
        ticTacToe.xPlay(0, 2);
        ticTacToe.ShowGame();
    }
}
