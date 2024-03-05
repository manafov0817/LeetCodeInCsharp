using System.Collections.Immutable;
using System.Text;

namespace NeetCodeProblems
{
    public static class Arrays
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
                set.Add(nums[i]);
            return set.Count != nums.Length;
        }
        public static bool IsAnagram(string s, string t)
        {

            char[] sArr = new char[26];

            // If Length is not same, letters are more in one of them
            if (s.Length != t.Length)
                return false;

            // Add one letter to array from first and remove the same from second. 
            for (int i = 0; i < s.Length; i++)
            {
                sArr[s[i] - 'a']++;
                sArr[t[i] - 'a']--;
            }

            // If array is empty, that means all added characters removed, this means
            // character counts are equal
            for (int i = 0; i < sArr.Length; i++)
            {
                if (sArr[i] != 0)
                    return false;
            }
            return true;
        }
        public static int[] GetConcatenation(int[] nums)
        {
            Span<int> res = stackalloc int[nums.Length * 2];
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                res[i] = nums[i];
                res[i + len] = nums[i];
            }

            return res.ToArray();
        }
        public static int[] ReplaceElements(int[] arr)
        {
            int len = arr.Length;
            int max = arr[len - 1];
            for (int i = len - 1; i > -1; i--)
            {
                var temp = arr[i];

                arr[i] = max;

                if (temp > max)
                    max = temp;

            }
            arr[len - 1] = -1;
            return arr;
        }
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
                return true;

            int subNum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (subNum < s.Length && t[i] == s[subNum])
                    subNum++;
            }

            return subNum == s.Length;
        }
    }
}

