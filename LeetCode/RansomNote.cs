using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (magazineDict.ContainsKey(c))
                {
                    magazineDict[c] += 1;
                }
                else
                {
                    magazineDict.Add(c, 1);
                }
            }

            // check if there are enough letters to build ransomeNote
            foreach (char c in ransomNote)
            {
                if (magazineDict.ContainsKey(c) && magazineDict[c] > 0) // check if dictionary contains key and if count is greater than 0
                {
                    magazineDict[c] -= 1; // remove 1 count of this char
                }
               else
                {
                    return false; // character is not available or insufficient
                }
            }
            return true; // if able to reach the end of the ransom note, every letter is available
        }

    }
}
