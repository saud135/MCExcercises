using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
//    String Challenge
//Have the function StringChallenge(str) take the str parameter being passed and return the smallest number you can get through the following reduction method.The method is: Only the letters a, b, and c will be given in str and you must take two different adjacent characters and replace it with the third.For example "ac" can be replaced with "b" but "aa" cannot be replaced with anything.This method is done repeatedly until the string cannot be further reduced, and the length of the resulting string is to be outputted.

//For example: if str is "cab", then "ca" can be reduced to "b" and you get "bb" (you can also reduce it to "cc"). The reduction is done so the output should be 2. If str is "bcab", "bc" reduces to "a", so you have "aab", then "ab" reduces to "c", and the final string "ac" is reduced to "b" so the output should be 1.
//Examples
//Input: "abcabc"
//Output: 2
//Input: "cccc"
//Output: 4
    public class StringChallange
    {

        public static string StringChallenge(string str)
        {
            if (str.Length > 2)
                if ((str[0] == 'a' && str[1] == 'b') || (str[0] == 'b' && str[1] == 'a'))
                {
                    str.Remove(str[0]);
                    str.Replace(str[0], 'c');


                }
                else if ((str[0] == 'a' && str[1] == 'c') || (str[0] == 'c' && str[1] == 'a'))
                {
                    str.Remove(str[0]);
                    str.Replace(str[0], 'b');
                }
                else if ((str[0] == 'b' && str[1] == 'c') || (str[0] == 'c' && str[1] == 'b'))
                {
                    str.Remove(str[0]);
                    str.Replace(str[0], 'a');
                }
                else if ((str[0] == 'b' && str[1] == 'b'))
                {
                    str.Replace(str[1],'c');
                    str.Replace(str[0], 'c');
                }

            //else if ((str[0] == 'a' && str[1] == 'c') || (str[0] == 'c' && str[1] == 'a'))
            //{
            //    str.Remove(str[0]);
            //    str.Replace(str[0], 'b');
            //}


            // code goes here  
            return str;

        }
    }
}
