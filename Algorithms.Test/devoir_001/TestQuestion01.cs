using Algorithms.devoir_001;

namespace Algorithms.Test;


[TestClass]
public class TestQuestion01
{
    [TestMethod]
    public void TestCalculateAverage()
    {
        Assert.AreEqual(0,new Question01(new List<double>{}).CalculateAverage());
        Assert.AreEqual(2,new Question01(new List<double>{2}).CalculateAverage());
        Assert.AreEqual(2,new Question01(new List<double>{1,2,3}).CalculateAverage());
    }
}