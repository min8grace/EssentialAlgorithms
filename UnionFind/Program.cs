﻿using System;

namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parent = new int[11];
            for (int i = 1; i <= 10; i++)
            {
                parent[i] = i;
            }
            unionParent(parent, 1, 2);
            unionParent(parent, 2, 3);
            unionParent(parent, 3, 4);
            unionParent(parent, 5, 6);
            unionParent(parent, 6, 7);
            unionParent(parent, 7, 8);
            Console.WriteLine($"Are 1 and 5 conneted? = { sameParentsCheck(parent, 1, 5)}");
        }

        public static int getParent(int[] parent, int x)
        {
            if (parent[x] == x) return x;
            return parent[x] = getParent(parent, parent[x]);
        }

        public static void unionParent(int[] parent, int a, int b)
        {
            a = getParent(parent, a);
            b = getParent(parent, b);
            if (a < b) parent[b] = a;
            else parent[a] = b;
        }

        public static bool sameParentsCheck(int[] parent, int a, int b)
        {
            a = getParent(parent, a);
            b = getParent(parent, b);
            if (a == b) return true;
            return false;
        }
    }

}

