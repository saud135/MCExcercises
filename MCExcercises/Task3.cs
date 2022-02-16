using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public static class Task3
    {
        /// <summary>
        ///        A    B 
        //case 1:  2    2  => 2 sticks from A and other 2 from B(c in solution)
        //case 2:  3    1  => 3 sticks from A and other 1 from B(d in solution)
        //case 3:  1    3  => 1 sticks from A and other 3 from B(b in solution)
        //case 4:  4    0  => 4 sticks from A(a in solution)
        //case 5:  0    4  => 4 sticks from B(e in solution)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int solution(int A, int B)
        {
            int a = A / 4;
            int b = Math.Min(A, B / 3);
            int c = Math.Min(A / 2, B / 2);
            int d = Math.Min(A / 3, B);
            int e = B / 4;
            return Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
        }
    }
}
