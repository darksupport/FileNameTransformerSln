using System.Linq;

namespace FileNameTransformer.TransformerActions
{
    public class ReversePath : AbstractAction
    {
        internal override string performAction(string path)
        {
            string[] pathElements = path.Split(Globals.PathSeparator.ToCharArray()).Reverse().ToArray();
            return string.Join(Globals.PathSeparator, pathElements);
        }
    }
}
