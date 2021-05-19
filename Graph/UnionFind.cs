using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    //Disjoint-Set Algorithm
    public class UnionFind
    {

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
    }

}
