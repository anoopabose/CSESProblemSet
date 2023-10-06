using System.Runtime.InteropServices;

public class Repetitions
{


    /*
    You are given a DNA sequence: a string consisting of characters A, C, G, and T. 
    Your task is to find the longest repetition in the sequence. 
    This is a maximum-length substring containing only one type of character.
    Input
    The only input line contains a string of n characters.
    Output
    Print one integer: the length of the longest repetition.
    Constraints
    •	1≤n≤106
    Example
    Input:
    ATTCGGGA
    Output:
    3

    */
    public static int SolveLongestRepition(string s)
    {
        int max = 0;
        char[] chars = s.ToCharArray();
        char first = ' ';
        int count = 1;
        foreach (char c in chars)
        {
            if (c == first)
            {
                count++;
            }
            else
            {
                count = 1;
            }
            first = c;
            max = Math.Max(max, count);

        }


        return max;
    }




    public static int Solve(string s)
    {
        int max = 0;
        char[] chars = s.ToCharArray();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < chars.Length; i++)
        {
            if (dict.ContainsKey(chars[i]))
            {
                dict[chars[i]]++;
            }
            else
            {
                dict.Add(chars[i], 1);
            }

            if (dict[chars[i]] > max)
            {
                max = dict[chars[i]];
            }
        }

        return max;

    }

}
