using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Greedy
{
    public class Prim
    {

        const int V = 5; // Number of vertices in the graph

        // Function to find the vertex with the minimum key value
        int MinKey(int[] key, bool[] mstSet)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < V; v++)
            {
                if (!mstSet[v] && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        // Function to print the constructed MST
        void PrintMST(int[] parent, int[,] graph)
        {
            Console.WriteLine("Edge \tWeight");
            for (int i = 1; i < V; i++)
            {
                Console.WriteLine($"{parent[i]} - {i} \t{graph[i, parent[i]]}");
            }
        }

        // Function that implements Prim's algorithm
        public void Run(int[,] graph)
        {
            int[] parent = new int[V]; // Array to store constructed MST
            int[] key = new int[V]; // Key values used to pick minimum weight edge
            bool[] mstSet = new bool[V]; // To represent the set of vertices included in MST

            // Initialize all keys as infinite and mstSet as false
            for (int i = 0; i < V; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            // Always include the first vertex in MST
            key[0] = 0; // Make key 0 so that this vertex is picked first
            parent[0] = -1; // First node is always the root of MST

            // The MST will have V vertices
            for (int count = 0; count < V - 1; count++)
            {
                // Pick the minimum key vertex from the set of vertices not yet included in MST
                int u = MinKey(key, mstSet);

                // Add the picked vertex to the MST set
                mstSet[u] = true;

                // Update key value and parent index of the adjacent vertices of the picked vertex
                for (int v = 0; v < V; v++)
                {
                    // Update the key only if graph[u][v] is smaller than key[v]
                    if (graph[u, v] != 0 && !mstSet[v] && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }

            PrintMST(parent, graph);
        }
    }
}
