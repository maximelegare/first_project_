namespace Algorithms.devoir_001;

public class Point
{
    private double x;

    private double y;

    public Point(double x, double y)
    {
        this.x = x;

        this.y = y;
    }

    public double X()
    {
        return x;
    }

    public double Y()
    {
        return y;
    }

    public Point GetMiddle(Point point2)
    {
        double newX = X() + point2.X() / 2;
        double newY = Y() + point2.Y() / 2;

        return new Point(newX, newY);
    }

    public double Distance()
    {
        return Math.Sqrt(X() * X() + Y() * Y());
    }
}

public class Circle
{
    private double x = 0;
    private double y = 0;

    private double r = 0;

    public Circle(double r)
    {
        this.r = r;
    }

    public Boolean IsIn(Point p)
    {
        double dist = Math.Sqrt(p.Y() * p.Y() + p.X() * p.X());
        return dist < r;
    }
}

public class Square
{
    private double x = 0;
    private double y = 0;

    private double c = 0;

    public Square(double c)
    {
        this.c = c;
    }

    public double Area()
    {
        return c * c;
    }

    public Point RandomPoint(Random rand)
    {
        return new Point(rand.NextDouble() * c - c / 2, rand.NextDouble() * c - c / 2);
    }
}

public class Pi
{
    public static double Estimate(int n)
    {
        Circle circle = new Circle(1);
        Square square = new Square(2);

        double squareArea = square.Area();
        Random rand = new Random(666);

        double isIn = 0;
        for (int i = 0; i < n; i++)
        {
            if (circle.IsIn(square.RandomPoint(rand)))
            {
                isIn++;
            }
        }

        return isIn * squareArea / n;
    }
}
