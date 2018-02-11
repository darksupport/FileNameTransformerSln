using log4net;
using System;
using System.IO;
using System.Linq;

namespace FileNameTransformer
{
    public class ParamsValidator : IParamsValidator
    {
        private static readonly ILog log = LogManager.GetLogger(nameof(ParamsValidator));

        void  validateArgs(string[] args)
        {
            if (args.Count() < 2)
            {
                throw new ArgumentException(ResourceStrings.IncorrectCountOfArgs);
            }

            if (args[0] == string.Empty)
            {
                throw new ArgumentNullException(ResourceStrings.EmptyPathDirectory);
            }

            if (args[1] == string.Empty)
            {
                throw new ArgumentNullException(ResourceStrings.EmptyTransformType);
            }

            validateDirectoryPath(args[0]);
            validateTransformType(args[1]);
        }

        void validateDirectoryPath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException(string.Format(ResourceStrings.DirectoryNotFound,path));
            }
        }

        void validateTransformType(string arg)
        {
            switch(arg)
            {
                case Globals.TransformTypes.AllTransformType :
                    break;
                case Globals.TransformTypes.CppTransformType :
                    break;
                case Globals.TransformTypes.ReversePathTransformType :
                    break;
                case Globals.TransformTypes.ReverseSympolsTransformType :
                    break;
                default:
                    throw new ArgumentOutOfRangeException(string.Format(ResourceStrings.IncorectTransformType, arg));
            }
        }

        public string Validate(string[] args)
        {
            string result = string.Empty;
            try
            {
                validateArgs(args);
            }
            catch (Exception e)
            {
                result = e.Message;
                log.Fatal(e.Message, e);
            }
            return result;
        }
    }
}
