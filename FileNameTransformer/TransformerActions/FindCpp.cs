using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTransformer.TransformerActions
{
    public class FindCpp : AbstractAction
    {
        static string fileNamePattern = ".cpp";
        static string additionalSymbol = " /";

        internal override string performAction(string path)
        {
            string result = string.Empty;
            if (path.Substring(path.Length - fileNamePattern.Length, fileNamePattern.Length) == fileNamePattern) //should be faster then regExp
            {
                result = path + additionalSymbol;
            }
            return result;
        }
    }
}
