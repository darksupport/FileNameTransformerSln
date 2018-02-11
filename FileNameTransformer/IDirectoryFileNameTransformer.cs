using System;
namespace FileNameTransformer
{
    public interface IDirectoryFileNameTransformer
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetAllFilesInDirAsync();
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> TransformFileNamesAsync(System.Collections.Generic.List<string> allFiles);
    }
}
