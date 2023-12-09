namespace test.abc117.c
{
    using src.abc117.c;
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
                    @"2 5
10 12 1 2 14";
                string output =
                    @"5";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_2()
            {
                string input =
                    @"3 7
-10 -3 0 9 -100 2 17";
                string output =
                    @"19";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_3()
            {
                string input =
                    @"100 1
-100000";
                string output =
                    @"0";

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