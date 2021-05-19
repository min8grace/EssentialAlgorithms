using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    // Minimum Spanning Tree(MST)
    // the point is the necessary edge-weight are the number of Edges -1;
    // Adding the minimum length in order without making a cycle  
    class KruskalAlgorithm
    {
        // UnionFind is needed
        public int getParent(int[] parent, int x)
        {
            if (parent[x] == x) return x;
            return parent[x] = getParent(parent, parent[x]);
        }

        public void unionParent(int[] parent, int a, int b)
        {
            a = getParent(parent, a);
            b = getParent(parent, b);
            if (a < b) parent[b] = a;
            else parent[a] = b;
        }

        public bool sameParentsCheck(int[] parent, int a, int b)
        {
            a = getParent(parent, a);
            b = getParent(parent, b);
            if (a == b) return true;
            return false;
        }

        //==============  

        public  class Edge
        {
            public int[] node = new int[2];
            public int distance;
            public Edge(int a, int b, int _distance)
            {
                this.node[0] = a;
                this.node[1] = b;
                this.distance = _distance;
            }
        }
    }
}
