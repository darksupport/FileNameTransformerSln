using FileNameTransformer.TransformerActions;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileNameTransformer
{
    //should be splited in a future (if the functionality in the future will expand)
    public class DirectoryFileNameTransformer : FileNameTransformer.IDirectoryFileNameTransformer 
    {
        string directoryPath = string.Empty;
        IAction pathTransformer;
        private static readonly ILog log = LogManager.GetLogger(nameof(DirectoryFileNameTransformer));

        public DirectoryFileNameTransformer(string directoryPath, IAction pathTransformer)
        {
            this.directoryPath = directoryPath;
            this.pathTransformer = pathTransformer;
        }

        public async Task<List<string>> GetAllFilesInDirAsync()
        {
            List<string> result = new List<string>();
            List<string> allFilesInDir = null;
            try
            {
                allFilesInDir = System.IO.Directory.GetFiles(directoryPath, Globals.FileSearchMask, System.IO.SearchOption.AllDirectories).ToList();
                allFilesInDir.ForEach(x => result.Add(x.Replace(directoryPath, string.Empty)));
            }
            catch (Exception e)
            {
                log.Error(ResourceStrings.ProblemWithFileNameCollect,e);
                throw;
            }
                                
            return result;
        }

        public async Task<List<string>> TransformFileNamesAsync(List<string> allFiles)
        {         
            List<string> result = new List<string>();            
            allFiles.ForEach(x => result.Add(pathTransformer.Perform(x)));
            result.RemoveAll(x => x == string.Empty);
            return result;
        }
    }
}
