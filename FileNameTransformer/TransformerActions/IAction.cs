using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTransformer.TransformerActions
{
    public interface IAction
    {
        string Perform(string path);
    }
}
