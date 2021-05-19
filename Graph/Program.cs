using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parent = new int[11];
            for(int i = 1; i <= 10; i++)
            {
                parent[i] = i;
            }

            UnionFind uf = new UnionFind();
            uf.unionParent(parent, 1, 2);
            uf.unionParent(parent, 2, 3);
            uf.unionParent(parent, 3, 4);
            uf.unionParent(parent, 5, 6);
            uf.unionParent(parent, 6, 7);
            uf.unionParent(parent, 7, 8);
            Console.WriteLine($"Are 1 and 5 conneted? = { uf.sameParentsCheck(parent,1,5)}");
        }
    }
}
