namespace test.abc305.a
{

    using src.abc305.a;
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
                    @"53";
                string output =
                    @"55";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_2()
            {
                string input =
                    @"21";
                string output =
                    @"20";

                AssertIO(input, output);
            }

            [TestMethod]
            public void 入力例_3()
            {
                string input =
                    @"100";
                string output =
                    @"100";

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