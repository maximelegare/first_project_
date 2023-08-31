namespace Algorithms;

using System;
using System.Drawing;
using System.Security.Cryptography;
using Algorithms.devoir_001;

class Exercises
{
    // public static void Question01(int Number)
    // {
    //     if (Number % 2 == 1)
    //     {
    //         Console.WriteLine("Number is odd");
    //     }
    //     else if (Number % 2 == 0 && Number > 0 && Number < 20)
    //     {
    //         Console.WriteLine("Number is small and pair");
    //     }
    //     else if (Number % 2 == 0 && Number > 20 && Number < 100)
    //     {
    //         Console.WriteLine("Big pair number");
    //     }
    //     else if (Math.Abs(Number) % 2 == 0 && Number < 0)
    //     {
    //         Console.WriteLine("negative pair number");
    //     }
    //     else{
    //         Console.WriteLine("Other number");
    //     }
    // }


    // public static void Question02(float Number){
    // }

    public static void Main()
    {
        Question01 question01 = new Question01(new List<double> {1,2,3});
        Console.WriteLine("[AVERAGE]: " + question01.CalculateAverage());

        Question02 question02 = new Question02();
        Console.WriteLine(question02.CreateStaircase(2, 3));
    }
};
