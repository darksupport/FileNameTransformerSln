using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTransformer.TransformerActions
{
    public class ReverseSymbolsInPath : AbstractAction
    {
        internal override string performAction(string path)
        {
            char[] charArray = path.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
