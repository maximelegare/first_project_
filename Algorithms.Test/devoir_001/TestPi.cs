using Algorithms.devoir_001;

namespace Algorithms.Test;

[TestClass]
public class TestPi
{
    [TestMethod]
    public void TestPiEstimate()
    {
        Assert.AreEqual(3.1416944271416942, Pi.Estimate(999999999));
    }
}
