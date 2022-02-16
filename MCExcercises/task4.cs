using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public static class Task4
    {
        public static int solution(int[] A)
        {
            return 0;
        }

        static void dfs(string[] board, int x, int y, int direction, SortedDictionary<string, bool> visited)
        {

            //string key = x + ":" + y + ":" + direction;
            //if (visited.ContainsKey(key))
            //{
            //    return;
            //}

            //if (x == board.Length || x == -1 || y == -1 || y == board[0].Length)
            //{
            //    // edge case : simple go back to prev x,y and change direction
            //    if (x == board.Length)
            //    {
            //        // current direction is down
            //        dfs(board, x - 1, y, 2, visited);
            //    }
            //    else if (x == -1)
            //    {
            //        //current direction is up
            //        dfs(board, x + 1, y, 0, visited);
            //    }
            //    else if (y == board[0].Length)
            //    {
            //        //current direction is right
            //        dfs(board, x, y - 1, 1, visited);
            //    }
            //    else if (y == -1)
            //    {
            //        //current direction is left
            //        dfs(board, x, y + 1, 3, visited);
            //    }
            //    return;
            //}

            //visited.Add(key, true);
            //if (board[x][y] != 'X')
            //{
            //    //keep moving in the same direction
            //    Item item = new Item(x, y);
            //    set.add(item);
            //    if (direction == 0)
            //    {
            //        dfs(board, x, y + 1, 0, visited);
            //    }
            //    else if (direction == 1)
            //    {
            //        dfs(board, x + 1, y, 1, visited);
            //    }
            //    else if (direction == 2)
            //    {
            //        dfs(board, x, y - 1, 2, visited);
            //    }
            //    else
            //    {
            //        dfs(board, x - 1, y, 3, visited);
            //    }
            //}
            //else
            //{
            //    //Same as edge case : go to prev x,y and change direction
            //    if (direction == 0)
            //    {
            //        dfs(board, x, y - 1, 1, visited);
            //    }
            //    else if (direction == 1)
            //    {
            //        dfs(board, x - 1, y, 2, visited);
            //    }
            //    else if (direction == 2)
            //    {
            //        dfs(board, x, y + 1, 3, visited);
            //    }
            //    else
            //    {
            //        dfs(board, x + 1, y, 0, visited);
            //    }
            //}

        }
    }
}
