using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public class GraphIsValidTree
    {/// <summary>
    /// ////////not a correct solution
    /// </summary>
        private int V;
        private List<int>[] adj;

        public void initExample1()
        {
            // Create a graph given
            // in the above diagram
           
            addEdge(1, 0);
            addEdge(0, 2);
            addEdge(0, 3);
            addEdge(3, 4);
            if (isTree())
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");
            adj = new List<int>[V];
        }
        public void initExample2()
        {
           
            addEdge(1, 0);
            addEdge(0, 2);
            addEdge(2, 1);
            addEdge(0, 3);
            addEdge(3, 4);

            if (isTree())
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");
            adj = new List<int>[V];
        }
        public GraphIsValidTree(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        
        }

        void addEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(w);
        }

        bool isCyclic(int v, bool[] visited, int parent)
        {
            visited[v] = true;
            int i;

            foreach (int vt in adj[v])
            {
                i = vt;

                // If an adjacent is not visited,
                // then recur for that adjacent
                if (!visited[i])
                {
                    if (isCyclic(i, visited, v))
                        return true;
                }

                // If an adjacent is visited and
                // not parent of current vertex,
                // then there is a cycle.
                else if (i != parent && parent != -1)
                    return true;
            }
            return false;
            
            
        }
        bool isTree()
        {

            bool[] visited = new bool[V];
            //for (int i = 0; i < V; i++)
            //    visited[i] = false;

            if (isCyclic(0, visited, -1))
                return false;

            // If we find a vertex which is not reachable
            // from 0 (not marked by isCyclicUtil(),
            // then we return false
            for (int u = 0; u < V; u++)
                if (!visited[u])
                    return false;

            return true;
        }
    }
}
