namespace Algorithms.devoir_001;

public class TicTacToe
{
    private readonly string x = "X";
    private readonly string o = "O";
    private readonly string empty = "";


    private string[][] gameStatus = new[]
    {
        new[] { ".", ".", "." },
        new[] { ".", ".", "." },
        new[] { ".", ".", "." }
    };

    private string nextPlayer = Players.o.ToString();
    public string NextPlayer => nextPlayer;

    private enum Players
    {
        x,
        o,
    }

    private enum SquareState
    {
        x,
        o,
        empty
    }


    public void xPlay(int positionX, int positionY)
    {
        if (positionX > 2)
        {
            // Throw error
        }
        else if (positionY > 2)
        {
            // Throw error
        }
        else if (gameStatus[positionY][positionX] != ".")
        {
            // Throw error
        }
        else
        {
            nextPlayer = Players.o.ToString();
            gameStatus[positionY][positionX] = Players.x.ToString();
        }
    }

    public void oPlay(int positionX, int positionY)
    {
        if (positionX > 2)
        {
            //Throw error
        }
        else if (positionY > 2)
        {
            // Throw error
        }
        else if (gameStatus[positionY][positionX] != ".")
        {
            // Throw error
        }
        else
        {
            nextPlayer = Players.x.ToString();
            gameStatus[positionY][positionX] = Players.o.ToString();
        }
    }

    
    public void ShowGame()
    {
        foreach (var subArray in gameStatus.Reverse())
        {
            Console.WriteLine(string.Join(", ", subArray).Replace(",", ""));
        }
    }
}
