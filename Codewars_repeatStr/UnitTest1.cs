using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_repeatStr
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0andstringNull_Should_Be_stringNull()
        {
            var n = 0;
            var s = string.Empty;

            var act = Program.repeatStr(n, s);

            var expected = string.Empty;

            Assert.AreEqual(expected, act);
        }
    }

    public class Program
    {
        public static string repeatStr(int i, string s)
        {
            throw new System.NotImplementedException();
        }
    }
}
