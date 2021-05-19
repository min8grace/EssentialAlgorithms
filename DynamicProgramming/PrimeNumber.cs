using System;
using System.Diagnostics;

namespace DynamicProgramming
{
    class PrimeNumber
    {
        static void Start()
        {
            Console.WriteLine("Enter the number");
            string input = Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine($"Result: "+ BruteForce(Int32.Parse(input)) );
            stopwatch.Stop();
            Console.WriteLine("BruteForce : Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);


            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine($"Result: " + UsingSquareRoot(Int32.Parse(input)));
            stopwatch.Stop();
            Console.WriteLine("UsingSquareRoot : Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

            EratothenesSieve(Int32.Parse(input));
        }

        //Elapsed time, Time Complexity = O(n)
        static bool BruteForce(int input)
        {
            for(int i=2; i<input; i++)
            {
                if (input % i == 0) return false;
            }

            return true;
        }

        //Elapsed time, Time Complexity = O(n^1/2)
        static bool UsingSquareRoot(int input)
        {
            int squareRoot = (int)Math.Sqrt((double)input);
            for (int i = 2; i < squareRoot; i++)
            {
                if (input % i == 0) return false;
            }

            return true;
        }

        //Elapsed time, Time Complexity = O(nlog n)
        static void EratothenesSieve(int input)
        {
            int[] visited = new int[90000000];
            for (int i = 2; i <= input; i++)
            {
                visited[i] = i;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 2; i <= input; i++)
            {
                if (visited[i] == 0) continue;
                else{
                    for(int j=i*2; j<=input; j = j + i)
                    {
                        visited[j] = 0;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("UsingSquareRoot : Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

            Console.Write($"Result: ");
            for (int i = 2; i <= input; i++)
            {
                if(visited[i] !=0) Console.Write(" "+i.ToString());
            }               
        }
    }
}
