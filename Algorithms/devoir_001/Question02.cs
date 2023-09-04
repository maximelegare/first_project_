namespace Algorithms.devoir_001;

public class Question02
{
    private string Repeat(string element, int number)
    {
        string ret = "";
        for (int i = 0; i < number; i++)
        {
            ret = ret + element;
        }
        return ret;
    }

    public string CreateStaircase(int height = 1, int width = 1)
    {
        string ret = "";
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= height; j++)
            {
                int nbrHashs = i * width;
                int nbrSpaces = (5 - i) * width;

                string spaces = Repeat(" ", nbrSpaces);
                string starts = Repeat("#", nbrHashs);
                ret += "" + spaces + starts + "\n";
            }
        }
        return ret;
    }

    public static void TestStaircase()
    {
        int height = 1;
        int width = 1;
        string result = new Question02().CreateStaircase();
        
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
                // Assert.IsTrue(sepResult[i*height + j].EndsWith(expected));
            }
            //Change expected
            for(int k=0; k<width; k++){
               expected+= "#"; 
            }
        }
    }

}
