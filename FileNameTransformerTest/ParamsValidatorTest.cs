using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using FileNameTransformer;
using System.IO;

namespace FileNameTransformerTest
{
    [TestFixture]
    public class ParamsValidatorTest
    {
        IParamsValidator validator;
        string[] args;
        [SetUp]
        public void Setup()
        {
            validator = new ParamsValidator();
            args = new string[2];
        }

        [Test]
        public void TestParamsValidator()
        {
            //normal params
            args[0] = Directory.GetCurrentDirectory();
            args[1] = "all";
            Assert.IsEmpty(validator.Validate(args));

            //directory path empty
            args[0] = "";
            args[1] = "cpp";
            Assert.IsNotEmpty(validator.Validate(args));

            //wrong directory path
            args[0] = "dkfjgdkf";
            args[1] = "cpp";
            Assert.IsNotEmpty(validator.Validate(args));

            //empty transform type
            args[0] = Directory.GetCurrentDirectory();
            args[1] = "";
            Assert.IsNotEmpty(validator.Validate(args));

            //wrong args count
            args = new string[1];
            Assert.IsNotEmpty(validator.Validate(args));

        }
    }
}
