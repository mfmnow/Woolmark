using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wool.Test.ReverseWords.Domain;

namespace Wool.Test.ReverseWords.UnitTests
{
    [TestClass]
    public class ReverseWordsServiceTester
    {
        [TestMethod]
        public void ResverseString_Should_Return_Right_String()
        {
            Assert.IsTrue(ReverseWordsService.ResverseString("abc def")=="fed cba");
        }

        [TestMethod]
        public void ResverseString2_Should_Return_Right_String()
        {
            Assert.IsTrue(ReverseWordsService.ResverseString2("abc def") == "fed cba");
        }
    }
}
