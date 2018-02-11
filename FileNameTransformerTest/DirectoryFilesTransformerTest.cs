using NUnit.Framework;
using Moq;
using FileNameTransformer.TransformerActions;
using FileNameTransformer;
using System.IO;
using System.Collections.Generic;

namespace FileNameTransformerTest
{
    [TestFixture]
    public class DirectoryFilesTransformerTest
    {
        Mock<IAction> mockAction;
        string mockStringVal = "mock string";
        [SetUp]
        public void SetUp()
        {
            mockAction = new Mock<IAction>();
            mockAction.Setup(mock => mock.Perform(It.IsAny<string>())).Returns(mockStringVal);
        }

        [Test]
        public async void GetAllFilesInDirAsyncTest()
        {
            string rootDir = Directory.GetCurrentDirectory();
            IDirectoryFileNameTransformer transformer = new DirectoryFileNameTransformer(rootDir, mockAction.Object);
            List<string> files = await transformer.GetAllFilesInDirAsync();
            Assert.NotNull(files);
            Assert.True(files.Count > 0);
            Assert.True(files.TrueForAll(x => !x.Contains(rootDir)));
        }

        [Test]
        public async void TransformFileNamesAsyncTest()
        {
            string rootDir = Directory.GetCurrentDirectory();
            IDirectoryFileNameTransformer transformer = new DirectoryFileNameTransformer(rootDir, mockAction.Object);
            List<string> files = await transformer.GetAllFilesInDirAsync();
            List<string> resultNames = await transformer.TransformFileNamesAsync(files);
            Assert.True(files.Count == resultNames.Count);
            Assert.True(resultNames.TrueForAll(x => x == mockStringVal));
        }

    }
}
