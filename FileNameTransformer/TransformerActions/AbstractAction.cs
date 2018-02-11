using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTransformer.TransformerActions
{
    public abstract class AbstractAction : IAction
    {
        private static readonly ILog log = LogManager.GetLogger(nameof(AbstractAction));

        public string Perform(string path)
        {
            try
            {
                log.Debug(string.Format(ResourceStrings.InvokeTransAct, nameof(this.GetType), path));
                string result = performAction(path);
                log.Debug(string.Format(ResourceStrings.ResultTransAct, result));
                return result;
            }
            catch(Exception e)
            {
                log.Error(string.Format(
                            ResourceStrings.ExceptionInPerfAct,
                             nameof(this.GetType), path), e);
                throw;
            }
        }

        abstract internal string performAction(string path);
    }
}
