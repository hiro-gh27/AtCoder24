namespace src.abc100.c;

public class Program
{

    class Resolver
    {
        private Dictionary<long, long> memo = new Dictionary<long, long>();

        public long dfs(long n)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n % 2 != 0)
            {
                return 0;
            }

            long count = dfs(n / 2)+1;
            memo.Add(n, count);
            return count;
        }
    }

    public static void Main(string[] args)
    {
        var sc = new Scanner();
        int N = sc.NextInt();

        Resolver r = new Resolver();
        long count = 0;
        for (int i = 0; i < N; i++)
        {
            int number = sc.NextInt();
            count += r.dfs(number);
        }
        Console.Out.WriteLine(count);

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