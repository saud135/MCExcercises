using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
   public class HQLabs
    {
        public static int ArrayChallenge(int[] arr)
        {
//            Have the function ArrayChallenge(arr) take the array of numbers stored in arr and determine the total number of duplicate entries.For example if the input is [1, 2, 2, 2, 3] then your program should output 2 because there are two duplicates of one of the elements.
//Examples
//Input: new int[] { 0, -2, -2, 5, 5, 5 }
//Output: 3
//Input: new int[] { 100, 2, 101, 4 }
//Output: 0

            // code goes here  

            Dictionary<int, int> duplicateEntries = new Dictionary<int, int>();
          foreach (var item in arr)
            {
                if (duplicateEntries.ContainsKey(item))
                    duplicateEntries[item] = duplicateEntries[item] + 1;

                else
                    duplicateEntries[item] = 0;

            }
            if (duplicateEntries.Values.Max() == 1)
                return 0;
            else
                return duplicateEntries.Values.Max();

        }

    }
}
