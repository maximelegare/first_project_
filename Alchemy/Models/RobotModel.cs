public class Robot
{
    private string name;
    private string url;
    private double height;
    private double weight;
    private string country;

    public string Name
    {
        get => name;
    }
    public string Url
    {
        get => url;
    }
    public double Height
    {
        get => height;
    }
    public double Weight
    {
        get => weight;
    }
    public string Country
    {
        get => country;
    }

    public Robot(string name, string url, double height, double weight, string country)
    {
        this.name = name;
        this.url = url;
        this.height = height;
        this.weight = weight;
        this.country = country;
    }
}