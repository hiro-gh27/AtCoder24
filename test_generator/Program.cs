
public class Program
{
    public static void Main(string[] args)
    {
        var sc = new Scanner();
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