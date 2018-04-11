using System;

namespace AnagramDetection
{
    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            string res = "";
            original = original.ToLower();
            test = test.ToLower();
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < original.Length; j++)
                {
                    if (original[j] == test[i])
                    {
                        res += original[j];
                        original = original.Remove(j, 1);
                        break;
                    }
                }
            }
            // your code goes here
            return res.Equals(test);
        }
    }
}
