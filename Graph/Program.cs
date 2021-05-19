using System;
using System.Collections.Generic;
using static Graph.KruskalAlgorithm;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int m = 11;
            List<Edge> v = new List<Edge>();
            v.Add(new Edge(1, 7, 12));
            v.Add(new Edge(1, 4, 28));
            v.Add(new Edge(1, 2, 67));
            v.Add(new Edge(1, 5, 17));
            v.Add(new Edge(2, 4, 24));
            v.Add(new Edge(2, 5, 62));
            v.Add(new Edge(3, 5, 20));
            v.Add(new Edge(3, 6, 37));
            v.Add(new Edge(4, 7, 13));
            v.Add(new Edge(5, 6, 45));
            v.Add(new Edge(5, 7, 73));


            // ascending oder based on the distances of nodes
            v.Sort((a, b) => a.distance.CompareTo(b.distance));
            v.ForEach(x => Console.WriteLine(x.distance));

            int[] parent = new int[n];
            for(int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            int sum = 0;
            KruskalAlgorithm ka = new KruskalAlgorithm();
            for (int i = 0; i < v.Count; i++)
            {
                //
                if (!ka.sameParentsCheck(parent, v[i].node[0] - 1, v[i].node[1] - 1))
                {
                    sum += v[i].distance;
                    ka.unionParent(parent, v[i].node[0] - 1, v[i].node[1] - 1); 
                }
            }

            Console.WriteLine(sum);
        }
    }
}
