using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public static class Task1
    {
        public static int solution(string text)
        {
            if (String.IsNullOrEmpty(text)) return 0;

            string balloon = "BALON";
            Hashtable ht = new Hashtable();

            foreach (var c in text)
            {
                if (balloon.Contains(c))
                {
                    if (!ht.ContainsKey(c)) 
                        ht.Add(c, 0);

                    ht[c] = (int)ht[c] + 1;
                }
            }

            string d = "LO";
            foreach (char c in d)
            {
                if (ht.ContainsKey(c))
                {
                    ht[c] = (int)ht[c] / 2;
                }
            }

            if (ht.Count < balloon.Length) return 0;

            int min = Int32.MaxValue;
            foreach (char c in ht.Keys)
            {
                min = Math.Min(min, (int)ht[c]);
            }

            return min;

        }
    }
}
