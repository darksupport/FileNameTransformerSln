using FileNameTransformer;
using FileNameTransformer.TransformerActions;
using NUnit.Framework;

namespace FileNameTransformerTest
{
    class ContainerTest
    {
       IContainer container;

       [SetUp]
        public void SetUp()
        {
            container = new Container();
        }

        [Test]
        public void DependencyResolveTest()
        {
            Assert.True(container.Resolve<IAction>(Globals.TransformTypes.AllTransformType) is AllPath);
            Assert.True(container.Resolve<IAction>(Globals.TransformTypes.CppTransformType) is FindCpp);
            Assert.True(container.Resolve<IAction>(Globals.TransformTypes.ReversePathTransformType) is ReversePath);
            Assert.True(container.Resolve<IAction>(Globals.TransformTypes.ReverseSympolsTransformType) is ReverseSymbolsInPath);
            Assert.True(container.Resolve<IParamsValidator>() is ParamsValidator);
            Assert.True(container.Resolve<ISaveResults>() is SaveResults);

        }
    }
}
