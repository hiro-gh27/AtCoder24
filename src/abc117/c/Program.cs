using System.Collections;

namespace src.abc117.c;

public class Program
{
    public static void Main(string[] args)
    {
        var sc = new Scanner();
        int N = sc.NextInt();
        int M = sc.NextInt();
        int[] X = new int[M];

        for (var i = 0; i < X.Length; i++)
        {
            X[i] = sc.NextInt();
        }

        Array.Sort(X);
        if (N == 1)
        {
            long distance = X[0] - X[^1];
            Console.Out.WriteLine(distance);
            return;
        }

        int[] ranges = new int[X.Length-1];
        for (int i = 1; i < X.Length; i++)
        {
            ranges[i-1] = X[i] - X[i - 1];
        }

        Array.Sort(ranges, (r1, r2)  => r2.CompareTo(r1));
        for (int i = 1; i < N && i < ranges.Length; i++)
        {
            ranges[i-1] = 0;
        }
        
        Console.Out.WriteLine(ranges.Sum());



    }

    class Scanner
    {
        private class StringTokenizer
        {
            private string[] tokens;
            private int i;

            public StringTokenizer(string str)
            {
                tokens = str.Split(" ");
                i = 0;
            }

            public bool hasMoreElements()
            {
                return i < tokens.Length;
            }

            public string NextToken()
            {
                int before = i;
                i++;
                return tokens[before];
            }
        }

        private StringTokenizer st;

        public string Next()
        {
            while (st == null  || !st.hasMoreElements())
            {
                st = new StringTokenizer(Console.ReadLine());
            }
            return st.NextToken();
        }

        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }

        public string? NextLine()
        {
            return Console.ReadLine();
        }

    }
}