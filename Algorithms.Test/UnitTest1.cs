namespace Algorithms.Test;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestName()
    {

        Assert.IsTrue(new Name("max", "leg").IsValid());
        Assert.IsFalse(new Name("max2", "leg").IsValid());
        Assert.IsFalse(new Name("", "").IsValid());
    }
    [TestMethod]
    public void TestPostalCode(){
        Assert.IsTrue(new PostalCode("k2k 2k2").IsValid());

        Assert.IsFalse(new PostalCode("p2p p2p").IsValid());
        Assert.IsFalse(new PostalCode("p2p p2P").IsValid());
        Assert.IsFalse(new PostalCode("p2p p2p").IsValid());
        Assert.IsFalse(new PostalCode("p2p p22").IsValid());
        Assert.IsFalse(new PostalCode("p2p 2pp").IsValid());
        Assert.IsFalse(new PostalCode("p2p ppp").IsValid());
        Assert.IsFalse(new PostalCode("p2p pp2").IsValid());
        Assert.IsFalse(new PostalCode("p2p 22p").IsValid());
        Assert.IsFalse(new PostalCode("p2p 222").IsValid());
    }
}