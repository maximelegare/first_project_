namespace Algorithms.devoir_001;

public class Question01
{
    List<double> Numbers;

    public Question01(List<double> Numbers)
    {
        this.Numbers = Numbers;
    }

    public double CalculateAverage()
    {
        double Total = 0;

        if (Numbers.Count == 0)
        {
            return 0;
        }
        else
        {
            foreach (double Number in Numbers)
            {
                Total += Number;
            }
            return Total / Numbers.Count;
        }
    }
}
