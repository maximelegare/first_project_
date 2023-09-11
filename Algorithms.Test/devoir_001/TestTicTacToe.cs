using Algorithms.devoir_001;

namespace Algorithms.Test;

[TestClass]
public class TestTicTacToe
{
    [TestMethod]
    public void TestTicTacToeGame()
    {
       TicTacToe ticTacToe = new TicTacToe();
        ticTacToe.xPlay(0, 0);
        Assert.AreEqual("o", ticTacToe.NextPlayer);
        ticTacToe.oPlay(1, 2);
        ticTacToe.xPlay(2, 1);
        ticTacToe.oPlay(2, 2);
        ticTacToe.xPlay(0, 2);
    }
}
