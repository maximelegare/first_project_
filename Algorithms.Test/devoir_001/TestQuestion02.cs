using Algorithms.devoir_001;
using System;
namespace Algorithms.Test;

[TestClass]
public class TestQuestion02
{
    [TestMethod]
    public static void TestStaircase()
    {
        int height = 2;
        int width = 3;
        string result = new Question02().CreateStaircase(height, width);
        
        var sepResult = result.Split('\n');

        string expected = "";
        //Establish pattern for first line
        for(int i=0; i<width; i++){
            expected+= "#";
        }


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < height; j++)
            {
                //Validate if ok
                Console.WriteLine(expected);
                Console.WriteLine(sepResult[i*height + j]);
                Assert.IsTrue(sepResult[i*height + j].EndsWith(expected));
            }
            //Change expected
            for(int k=0; k<width; k++){
               expected+= "#"; 
            }
        }
    }
}
