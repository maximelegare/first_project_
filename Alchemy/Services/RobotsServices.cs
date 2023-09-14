namespace Alchemy.Services;

public class RobotsService : IRobotsService
{
    public Robot CreateRobot(string Name, int Height, int Weight, string Country)
    {
        return new Robot(Name, $"https://robohash.org/{Name}", Height, Weight, Country);
    }

    private List<Robot> listRobots = new List<Robot>
    {
        new Robot("max", "https://robohash.org/max", 10, 6, "Japan"),
        new Robot("Fred", "https://robohash.org/fred", 29, 1, "Danmark"),
        new Robot("Marc", "https://robohash.org/marc", 2, 89, "new zealand"),
    };
    public List<Robot> ListRobots 
    {
        get { return listRobots; }
        set { listRobots = value; }
    }
}
