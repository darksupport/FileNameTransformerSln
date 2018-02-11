using System;
using NUnit.Framework;
using FileNameTransformer.TransformerActions;

namespace FileNameTransformerTest.TransformerActions
{
    [TestFixture]
    public class ReverseSymbolsInPathTest
    {
        [Test]
        public void PerformReverseSymbolsTest()
        {
            IAction reverseSymbolsAction = new ReverseSymbolsInPath();
            string testString = "123456789";
            string controlString = "987654321";

            Assert.True(controlString == reverseSymbolsAction.Perform(testString));
            Assert.Throws(typeof(NullReferenceException), delegate { reverseSymbolsAction.Perform(null); });
        }
    }
}
