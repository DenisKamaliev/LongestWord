using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    internal class LongestWord
    {
        public static int Counter(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                    count++;

            }
            return count;
        }
    }
    
}
