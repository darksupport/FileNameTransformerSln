using System;
using System.IO;

namespace FileNameTransformer
{
    public static class Globals
    {
        public static class TransformTypes
        {
            public const string AllTransformType = "all";
            public const string CppTransformType = "cpp";
            public const string ReversePathTransformType = "reversed1";
            public const string ReverseSympolsTransformType = "reversed2";
        }

        public static string PathSeparator = Convert.ToString(Path.DirectorySeparatorChar);
        public static string FileSearchMask = ResourceStrings.FileSearchMask;
        public static string ResultFileName = ResourceStrings.ResultFile;


        public static IContainer container = new Container();

        public static IContainer Container
        {
            get
            {
                return container;
            }
        }
      
    }
}
