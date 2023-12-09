namespace src.abc305.a;

public class Program
{
    public static void Main(string[] args)
    {
        var sc = new Scanner();
        var N = sc.NextInt();

        var minDiff = Int32.MaxValue;
        var ans = Int32.MaxValue;

        for (int i = 0; i <= 100; i++)
        {
            int diff = (i * 5) - N;
            diff = Math.Abs(diff);
            if (diff < minDiff)
            {
                minDiff = diff;
                ans = i * 5;
            }
        }
        Console.Out.WriteLine(ans);
    }

    class Scanner
    {
        class StringTokenizer
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
                int evacuate = i;
                i++;
                return tokens[evacuate];
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