using src.abc330.a;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AtCoder
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void 入力例_1()
        {
            string input =
                @"5 60
60 20 100 90 40";
            string output =
                @"3";

            AssertIO(input, output);
        }

        [TestMethod]
        public void 入力例_2()
        {
            string input =
                @"4 80
79 78 77 76";
            string output =
                @"0";

            AssertIO(input, output);
        }

        [TestMethod]
        public void 入力例_3()
        {
            string input =
                @"10 50
31 41 59 26 53 58 97 93 23 84";
            string output =
                @"6";

            AssertIO(input, output);
        }

        private void AssertIO(string input, string output)
        {
            StringReader reader = new StringReader(input);
            Console.SetIn(reader);

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);

            Assert.AreEqual(output + Environment.NewLine, writer.ToString());
        }
    }
}

