namespace test.abc100.c
{
    using src.abc100.c;
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
                    @"3
5 2 4";
                string output =
                    @"3";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_2()
            {
                string input =
                    @"4
631 577 243 199";
                string output =
                    @"0";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_3()
            {
                string input =
                    @"10
2184 2126 1721 1800 1024 2528 3360 1945 1280 1776";
                string output =
                    @"39";

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

}