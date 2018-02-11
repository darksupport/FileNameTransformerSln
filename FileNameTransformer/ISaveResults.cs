using System;
using System.Threading.Tasks;
namespace FileNameTransformer
{
    public interface ISaveResults
    {
        Task SaveToFile(System.Threading.Tasks.Task<System.Collections.Generic.List<string>> dataToSave, string resultFileName);
    }
}
