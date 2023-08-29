class Exercises
{
    class Point
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

        public Point GetMiddle(Point point2){
            double newX = X() + point2.X() / 2;
            double newY = Y() + point2.Y() / 2;

            return new Point(newX, newY);
        }

        public double Distance()
        {
            return Math.Sqrt(X() * X() + Y() * Y());
        }
    }

    

    public static void Main_() {
        Point point = new(1,2);
     }
}
