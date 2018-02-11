using System;
using NUnit.Framework;
using FileNameTransformer.TransformerActions;

namespace FileNameTransformerTest.TransformerActions
{
    [TestFixture]
    public class FindCppTest
    {
        [Test]
        public void PerformFindCppTest()
        {
            IAction findCppAction = new FindCpp();
            string testString = "test\\value\\file.cpp";
            string controlString = "test\\value\\file.cpp /";

            Assert.True(controlString == findCppAction.Perform(testString));
            Assert.Throws(typeof(NullReferenceException), delegate { findCppAction.Perform(null); });
        }
    }
}
