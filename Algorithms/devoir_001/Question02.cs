namespace Algorithms.devoir_001;

public class Question02
{
    private string Repeat(string element, int number)
    {
        string ret = "";
        for (int i = 0; i < number; i++)
        {
            ret = ret + element;
        }
        return ret;
    }

    public string CreateStaircase(int height = 1, int width = 1)
    {
        string ret = "";
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= height; j++)
            {
                int nbrHashs = i * width;
                int nbrSpaces = (5 - i) * width;

                string spaces = Repeat(" ", nbrSpaces);
                string starts = Repeat("#", nbrHashs);
                ret += "" + spaces + starts + "\n";
            }
        }
        return ret;
    }
}
