using Algorithms.devoir_001;
using System;

namespace Algorithms.Test;

[TestClass]
public class TestQuestion02
{
    // [TestMethod]
    public  bool CreateStaircaseForTesting(int height, int width)
    {
        string result = new Question02().CreateStaircase(height, width);
        bool ret = true;
        var sepResult = result.Split('\n');

        string expected = "";
        //Establish pattern for first line
        for (int i = 0; i < width; i++)
        {
            expected += "#";
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < height; j++)
            {
                //Validate if ok
                Console.WriteLine(expected);
                Console.WriteLine(sepResult[i * height + j]);
                if (!sepResult[i * height + j].EndsWith(expected))
                {
                    ret = false;
                }
            }
            //Change expected
            for (int k = 0; k < width; k++)
            {
                expected += "#";
            }
        }
        return ret;
    }

    [TestMethod]
    public  void TestStaircase()
    {
        Assert.AreEqual(true, CreateStaircaseForTesting(1, 2));
    }
}
