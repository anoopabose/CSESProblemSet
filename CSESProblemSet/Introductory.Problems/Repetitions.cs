public class Repetitions
{
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