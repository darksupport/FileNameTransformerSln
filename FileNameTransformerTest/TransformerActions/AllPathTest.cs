using System;
using NUnit.Framework;
using FileNameTransformer.TransformerActions;

namespace FileNameTransformerTest.TransformerActions
{
    [TestFixture]
    public class AllPathTest
    {
        [Test]
        public void PerformAllPathTest()
        {
            IAction allPathAction = new AllPath();
            string testString = "test value";

            Assert.True(testString == allPathAction.Perform(testString));
            Assert.True(null == allPathAction.Perform(null));
        }
    }
}
