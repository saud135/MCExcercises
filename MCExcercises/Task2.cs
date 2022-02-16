using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public static class Task2
    {
        public static int solution(string S)
        {

           int consecutiveLength = 1;
            int result = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] != S[i + 1])
                {
                    consecutiveLength = 1;
                    //continue;
                }
                else if (S[i] == S[i + 1])
                    consecutiveLength += 1;


                if (consecutiveLength == 3)
                {
                    result += 1;
                    consecutiveLength = 0;
                   // continue;
                }
            }

            return result;
        }
    }
}
