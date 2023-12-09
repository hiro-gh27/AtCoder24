namespace src.abc330.a;
using System;
using System.IO;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        String line = Console.ReadLine();
        string[] inputs = line.Split(" ");

        long N = long.Parse(inputs[0]);
        long L = long.Parse(inputs[1]);

        int count = 0;
        string[] points = Console.ReadLine().Split(" ");
        foreach (string point in points)
        {
            long value = long.Parse(point);
            if (value >= L)
            {
                count++;
            }
        }

        Console.Out.WriteLine(count);
    }
}
