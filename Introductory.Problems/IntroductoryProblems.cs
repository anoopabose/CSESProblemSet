using System;

namespace CSESProblemSet.Introductory.Problems;

public static class IntroductoryProblems
{

    public static void Excecute()
    {
        WeirdAlgorithm.Solve(3);
        Console.WriteLine(MissingNumber.Solve(5, new int[] { 1, 2, 3, 5 }));
    }

}