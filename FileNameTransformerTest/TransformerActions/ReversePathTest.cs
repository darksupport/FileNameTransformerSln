using System;
using NUnit.Framework;
using FileNameTransformer.TransformerActions;

namespace FileNameTransformerTest.TransformerActions
{
    [TestFixture]
    public class ReversePathTest
    {
        [Test]
        public void PerformReversePathTest()
        {
            IAction reversePathAction = new ReversePath();
            string testString = "test\\value\\file.x";
            string controlString = "file.x\\value\\test";

            Assert.True(controlString == reversePathAction.Perform(testString));
            Assert.Throws(typeof(NullReferenceException), delegate { reversePathAction.Perform(null); });
        }
    }
}
