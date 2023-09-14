namespace Alchemy.Services;

public interface IRobotsService{
    public Robot CreateRobot(string Name, int Height, int Weight, string Country );
    public List<Robot> ListRobots{
        get;
        set;
    }
}


