public class MissingNumber
{
    public static int Solve(int n, int[] input)
    {
        Console.WriteLine("Input : " + Array.ConvertAll(input, x => x.ToString()).Aggregate((x, y) => x + " " + y));
        int sum = input.Aggregate((x, y) => x + y);
        return (n * (n + 1) / 2) - sum;

    }

}